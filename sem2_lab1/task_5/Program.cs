using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /*
         * test case : StreamReader file = new StreamReader("file.txt");
         */
        StreamReader file = new StreamReader("Text.txt");
        string[] uniqueWords = new string[1000];
        int[] wordCounts = new int[1000];
        int simvol; // поточ символ
        string Word = ""; // поточ слово
        int uniqueWord = 0;
        while ((simvol = file.Read()) != -1)
        {
            if (simvol == ' ' || simvol == ',' || simvol == '.' ||
                simvol == ';' || simvol == ':' || simvol == '!' ||
                simvol == '?' || simvol == '(' || simvol == ')' ||
                simvol == '"' || simvol == '\'' || simvol == '\n' ||
                simvol == '\t' || simvol == '\r')
            {
                if (!String.IsNullOrEmpty(Word))
                {
                    int index = Array.IndexOf(uniqueWords, Word);
                    if (index == -1)
                    {
                        uniqueWords[uniqueWord] = Word;
                        wordCounts[uniqueWord] = 1;
                        uniqueWord++;
                    }
                    else
                    {
                        wordCounts[index]++;
                    }
                    Word = "";
                }
            }
            else
            {
                Word += (char)simvol;
            }
        }
        
        file.Close();
        for (int i = 0; i < uniqueWord; i++)
        {
            Console.WriteLine(uniqueWords[i] + " - " + wordCounts[i]);
        }
        Console.ReadLine();
    }
    /*
     * test case : Протягом - 1
к?лькох - 1
стол?ть - 1
багато - 1
?нтелектуал?в - 1
намагалися - 1
встановити - 1
принципи - 1
справедливост? - 1
?рунтуючись - 1
на - 2
переконанн? - 1
що - 2
людина - 2
народжується - 1
<чистим - 1
листом> - 1
якому - 1
батьки - 1
та - 6
сусп?льство - 1
записують - 1
її - 1
б?ограф?ю - 1
Багато - 1
автор?в - 1
в?дчайдушно - 1
намагаються - 1
дискредитувати - 1
припущення - 1
про - 2
вроджений - 1
характер - 1
людських - 1
властивостей - 1
адже - 1
якщо - 2
люди - 1
народжуються - 1
р?зними - 1
то - 1
виправдано - 1
дискрим?нац?ю - 1
расизм - 1
- - 1
продукт - 1
б?олог?ї - 1
тод? - 1
свобода - 2
вол? - 2
є - 1
лише - 1
м?фом - 1
а - 3
життя - 1
не - 2
має - 1
вищого - 1
сенсу - 1
мети - 1
П?нкер - 2
переконливо - 1
показує - 1
в?дмова - 1
в?д - 1
анал?зу - 1
питань - 1
людської - 1
природи - 1
т?льки - 1
суперечить - 1
сучасним - 1
в?дкриттям - 1
у - 2
генетиц? - 1
нейроб?олог?ї - 1
теор?ї - 1
еволюц?ї - 1
й - 1
спотворює - 1
наш? - 1
уявлення - 1
себе - 1
Чи - 3
успадковуються - 1
?нтелект - 1
таланти - 1
можна - 1
викор?нити - 1
насильство - 1
в?дносинах - 1
м?ж - 1
людьми - 1
державами - 1
?снує - 1
разом - 1
?з - 2
нею - 1
? - 1
в?дпов?дальн?сть - 1
за - 1
свої - 1
вчинки - 1
Про - 1
ц? - 1
питання - 1
м?ркує - 1
когн?тивний - 1
психолог - 1
Ст?вен - 1
в - 1
одн?й - 1
найзначн?ших - 1
своїх - 1
книг - 1


     */
}