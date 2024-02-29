using System;

class Program
{
    static double POW(double x, double n)
    {
        double result = x;
        if (n == 0) return 1;
        for (int j = 1; j < n; j++)
            result *= x;
        return result;
    }

    static double FAC(double n)
    {
        double factorial = 1;
        for (int j = 1; j <= n; j++)
            factorial *= j;
        return factorial;
    }
    static double SIN(double val)
    {
        while (val > 3.14159265359*2)
        {
            val -= 3.14159265359*2;
        }
        double result = 0;
        for (int i = 0; i < 10; i++)
        {
            double a = POW(-1,i);
            double x = POW(val, (2*i)+1);
             
            double f = FAC((2*i)+1);
            
            result += (a * x / f);
        }

        return result;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Input number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("With Mathematics Library: " + Math.Sin(a));
            Console.WriteLine("Without using a library: " + SIN(a));
        }
        
    }
}