using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input x0: ");
        double x0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input xk: ");
        double xk = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input dx: ");
        double dx = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double a = 0.0084;
        double x = x0;
        int number = 9;
        if (x0 == 0 || xk ==0 || dx == 0 || b ==0)
        {
            Console.WriteLine("ERROR, invalid value");
        }
        else
        {
           while (x >= (xk + dx / 2))
                  {
                      while (number > 0)
                      {
                           double y = x * Math.Sin(Math.Sqrt(x + b - a));
                                               Console.WriteLine("X= " + x);
                                               Console.WriteLine("Y= " + y);
                                               x = x + dx;
                                               number--;
                      }
                    
                  }  
        }
        
    }
}