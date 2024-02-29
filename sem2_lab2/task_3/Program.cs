using System;

// клас Vector
class Vector
{
    private int[] values; // приватне поле

    public Vector(int size)
    {
        values = new int[size]; // конструктор масиву
    }

    public int this[int index]
    {
        get { return values[index]; }    // заповнення масиву
        set { values[index] = value; }
    }

    public int Length
    {
        get { return values.Length; } // розмір масиву
    }

    // перевантажена операція обчислення суми від'ємних елементів двох векторів
    public static int operator |(Vector vector1, Vector vector2)
    {
        int sum = 0;

        for (int i = 0; i < Math.Max(vector1.values.Length, vector2.values.Length); i++)
        {
            if (i < vector1.values.Length && vector1[i] < 0)
            {
                sum += vector1[i];
            }
            if (i < vector2.values.Length && vector2[i] < 0)
            {
                sum += vector2[i];
            }
        }

        return sum;
    }

    // перевантажена операція обчислення добутку елементів двох векторів із парними номерами
    public static int operator *(Vector vector1, Vector vector2)
    {
        int product = 0;

        for (int i = 0; i < Math.Min(vector1.values.Length, vector2.values.Length); i += 2)
        {
            product += vector1[i] * vector2[i];
        }

        return product;
    }

    // метод для розрахунку кількості елементів у векторі, які дорівнюють 0
    public int Zeroes()
    {
        int count = 0;

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == 0)
            {
                count++;
            }
        }

        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector vector1 = new Vector(4);
        
        vector1[0] = -1;
        vector1[1] = 2;
        vector1[2] = -3;
        vector1[3] = 4;

        Vector vector2 = new Vector(5);
        
        vector2[0] = -4;
        vector2[1] = 0;
        vector2[2] = -6;
        vector2[3] = 7;
        vector2[4] = -8;

        int sum_negative = vector1 | vector2;
        Console.ForegroundColor = ConsoleColor.Red;  
        Console.WriteLine("Сума вiд'ємних елементiв двох векторiв: {0}", sum_negative);
        Console.ResetColor();  

        
        int parni_numbers = 1;
        for (int i = 0; i < Math.Min(vector1.Length, vector2.Length); i++)
        {
            if (i % 2 == 0)
            {
                parni_numbers *= vector1[i] * vector2[i];
            }
        }
        Console.ForegroundColor = ConsoleColor.Blue;  
        Console.WriteLine("Добуток елементiв двох векторiв iз парними номерами: {0}", parni_numbers);
        Console.ResetColor(); 
        
        int zero_count = 0;
        for (int i = 0; i < Math.Max(vector1.Length, vector2.Length); i++)
        {
            if ((i < vector1.Length && vector1[i] == 0) || (i < vector2.Length && vector2[i] == 0))
            {
                zero_count++;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Кiлькiсть елементiв двох векторiв, рiвних 0: {0}", zero_count);
        Console.ResetColor(); 
        Console.ReadLine();
    }
}