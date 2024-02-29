using System;

class Table
{
    
    private int id;        
    private string lastName;
    private double salary;  // Зарплата 
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


    public string Information()
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

class Program
{
    static void Main()
    {

        Table[] records = new Table[3];

        for (int i = 0; i < records.Length; i++)
        {
            Console.WriteLine($"Введіть дані про {i + 1}-го працівника:");

            Console.Write("Номер зарплати: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Зарплата (грн): ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Утримано (грн): ");
            double withheld = double.Parse(Console.ReadLine());

            records[i] = new Table(id, lastName, salary, withheld);
        }

     
        Console.WriteLine("\nЗарплати працівників:");
        foreach (Table record in records)
        {
            Console.WriteLine(record.Information());
        }

    
        double total_salary = 0;
        double total_withheld = 0;
        double total_received = 0;

        foreach (Table record in records)
        {
            total_salary += record.Get_salary();
            total_withheld += record.Get_withheld();
            total_received += record.Get_received();
        }

        // Виводимо загальну суму зарплат, утримань та отриманих сум для всіх працівників
        Console.WriteLine($"\nЗагальна сума зарплат: {total_salary} грн");
        Console.WriteLine($"Загальна сума утримань: {total_withheld} грн");
        Console.WriteLine($"Загальна сума, що отримана працівниками: {total_received} грн");
    }
}