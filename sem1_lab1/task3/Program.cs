using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input number for factorial: ");
        Int64 n = Convert.ToInt64(Console.ReadLine());
        int factorial = 1;
        Int64 x;
        Int64 x_stepen;
        if (n>=0)
        {
               for (int i = 1; i <= n; i++) 
                 {
                     factorial *=  i;
                 }
                 Console.WriteLine("FACTORIAL : " + factorial);
                 Console.Write("Input number: ");
                 x = Convert.ToInt64(int.Parse(Console.ReadLine()));
                 x_stepen = Convert.ToInt64(Math.Pow(x, n));
                 Console.Write("Number to the power of n : " + x_stepen);   
        }
        else
        {
            Console.Write("Invalid number");   
        }
    }
}