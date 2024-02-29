using System;

class Program
{
    static void Main(string[] args)
    {
        bool prime_number = true;
        Console.Write("Input your number : ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0 || number == 1)
        {
            Console.WriteLine("Your number none");
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    prime_number = false;
                    break;
                }
            }
            if (prime_number)
            {
                Console.WriteLine("Your number prime");
            }
            else
            {
                Console.WriteLine("Your number not prime");
            }  
        }
        
    }
}