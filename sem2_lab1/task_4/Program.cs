using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /*
         test case : string student = "students_test.csv"; 
         */
        string student = "students.csv";
        bool found = false;
        try
        {
            using (StreamReader reader = new StreamReader(student))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = Split(line);
                    
                    string firstName = fields[0];
                    string lastName = fields[1];
                    int score = int.Parse(fields[2]);

                    if (score < 60)
                    {
                        Console.WriteLine("{0} {1} {2}", firstName, lastName,score);
                        found = true;
                    }
                    
                }
                if (!found)
             {
                Console.WriteLine("Студенти з результатом менше 60 балів не знайдені! ");
             }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка:  {0}", e.Message);
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
         test case : Console.WriteLine("Студенти з результатом менше 60 балів не знайдені! ");; 
         */
}