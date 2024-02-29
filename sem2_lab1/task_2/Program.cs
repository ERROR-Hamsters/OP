using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("numbers.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        Random random = new Random();

        for (int i = 0; i < 15; i++)
        {
            double number = random.NextDouble() * 100;
            sw.Write(number + " ");
        }

        sw.Close();
        fs.Close();
        
        FileStream rf = new FileStream("numbers.txt", FileMode.Open);
        StreamReader rd = new StreamReader(rf);
        string fileContent = rd.ReadToEnd();
        rd.Close();
        rf.Close();

        double max = 0;
        string numberString = "";

        foreach (char chislo in fileContent)
        {
            if (chislo != ' ')
            {
                numberString += chislo;
            }
            else
            {
                double number = Double.Parse(numberString);
                if (number > max)
                {
                    max = number;
                }

                numberString = "";
            }
        }
        
        FileStream wf = new FileStream("max.txt", FileMode.Create);
        StreamWriter w = new StreamWriter(wf);
        w.Write(max);
        w.Close();
        wf.Close();

        Console.WriteLine("Максимальне число: " + max);
    }
}