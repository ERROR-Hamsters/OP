using System;
using System.Collections.Generic;

class Table
{

    private int id;
    private string lastName;
    private double salary; // Зарплата 
    private double withheld;// Утримано 
    private double received;// Отримано 
  
    public Table(int id, string lastName, double salary, double withheld)
    {
        this.id = id;
        this.lastName = lastName;
        this.salary = salary;
        this.withheld = withheld;
        this.received = salary - withheld;
    }


    public string Get_info()
    {
        return $"#{id}, {lastName}, {salary} грн, {withheld} грн, {received} грн";
    }

    public double Get_salary()
    {
        return salary;
    }


    public double Get_withheld()
    {
        return withheld;
    }


    public double Get_received()
    {
        return received;
    }
}

class Table_list
{
    private List<Table> records;
    public Table_list()
    {
        records = new List<Table>();
    }

    public void Add_record(Table record)
    {
        records.Add(record);
    }


    public double Total_Salary()
    {
        double total_salary = 0;

        foreach (Table record in records)
        {
            total_salary += record.Get_salary();
        }

        return total_salary;
    }

    public double Total_Withheld()
    {
        double total_withheld = 0;

        foreach (Table record in records)
        {
            total_withheld += record.Get_withheld();
        }

        return total_withheld;
    }

    public double Total_Received()
    {
        double total_received = 0;

        foreach (Table record in records)
        {
            total_received += record.Get_received();
        }

        return total_received;
    }

    public void print()
    {
        Console.WriteLine("\nЗарплати працівників:");

        foreach (Table record in records)
        {
            Console.WriteLine(record.Get_info());
        }
    }
}

class Program
{
    static void Main()
    {
        // Створюємо список записів у відомості
        Table_list recordsList = new Table_list();
        // Вводимо вихідні дані про зарплати працівників
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Введіть дані про {i + 1}-го працівника:");

            Console.Write("Номер зарплати: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Прізвище: ");
            string lastName = Console.ReadLine();
            Console.Write("Зарплата (грн): ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Сума утримань (грн): ");
            double withheld = double.Parse(Console.ReadLine());

            // Створюємо об'єкт запису та додаємо його до списку записів
            Table record = new Table(id, lastName, salary, withheld);
            recordsList.Add_record(record);
        }


        recordsList.print();


        Console.WriteLine($"\nЗагальна сума зарплат: {recordsList.Total_Salary()} грн");
        Console.WriteLine($"Загальна сума утримань: {recordsList.Total_Withheld()} грн");
        Console.WriteLine($"Загальна сума, що отримали працівники: {recordsList.Total_Received()} грн");
    }
}
