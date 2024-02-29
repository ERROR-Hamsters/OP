using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       /*
        * test case : students_test.csv
        */
        string studentCsvFile = "students.csv";
        string studentBinaryFile = "students.bin";
        try
        {
            using (StreamReader reader = new StreamReader(studentCsvFile))
            using (BinaryWriter writer = new BinaryWriter(File.Open(studentBinaryFile, FileMode.Create)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = Split(line);
                    string firstName = fields[0];
                    string lastName = fields[1];
                    int score;
                    if (int.TryParse(fields[2], out score)) 
                    {
                        writer.Write(firstName);
                        writer.Write(lastName);
                        writer.Write(score);
                    }
                    else
                    {
                        Console.WriteLine("Помилка: неправильний формат оцінки {0} для студента {1} {2}", fields[2], firstName, lastName);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка: {0}", e.Message);
        }

        string studentHighScoreFile = "students_high_score.bin";
        try
        {
            using (BinaryReader reader = new BinaryReader(File.Open(studentBinaryFile, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(studentHighScoreFile, FileMode.Create)))
            {
                int count = 0;

                while (reader.PeekChar() > -1)
                {
                    string firstName = reader.ReadString();
                    string lastName = reader.ReadString();
                    int score = reader.ReadInt32();

                    if (score > 95)
                    {
                        writer.Write(firstName);
                        writer.Write(lastName);
                        writer.Write(score);
                        count++;
                        Console.WriteLine("{0} {1} {2}", firstName, lastName,score);
                    }
                }

                Console.WriteLine("Кількість студентів з результатом більше 95: {0}", count);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка: {0}", e.Message);
        }

        Console.ReadLine();
    }

    static string[] Split(string line)
    {
        string[] fields = new string[3];
        int now = 0;
        int start = 0;
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {

            if (line[i] == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (line[i] == ',' && !inQuotes)
            {
                string field = "";

                for (int j = start; j < i; j++)
                {
                    field += line[j];
                }

                fields[now] = field;
                now++;
                start = i + 1;
            }
        }

        string lastField = "";
        for (int j = start; j < line.Length; j++)
        {
            lastField += line[j];
        }

        fields[now] = lastField;
        return fields;
    }
    /*
 * test case : К?льк?сть студент?в з результатом б?льше 95: 0
 */
}