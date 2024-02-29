using System;
using System.IO;

class Program
{
    static void Main()
    {
        string input = @"C:\Users\KATE\Desktop\input.txt";
        string output = @"C:\Users\KATE\Desktop\output.txt";

        string[] lines = File.ReadAllLines(input);

        Sort(lines);

        File.WriteAllLines(output, lines);

        Console.WriteLine("Все відсортовано у файл ");
    }

    static void Sort(string[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            string current = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j].CompareTo(current) > 0)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
    }
}