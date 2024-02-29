using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileStream file = new FileStream("text.txt", FileMode.Create);
        StreamWriter writer = new StreamWriter(file);
        writer.WriteLine("Hello, my name Kate!");
        writer.WriteLine("I'm 18 y.o. !");
        writer.Close(); 
      
        
        StreamReader reader = new StreamReader("text.txt");
        string fileContent = reader.ReadToEnd();
        reader.Close(); 
        Console.WriteLine("Зміст файлу:");
        Console.WriteLine(fileContent);
    }
}