using System;
using System.IO;

namespace HandleFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1 - Using the simple FileInfo and File
             * 
            string sourcePath = @"//Users/silviocressoni/Documents/Studyies/DEV/C#/Text1.txt";
            string target = @"//Users/silviocressoni/Documents/Studyies/DEV/C#/Text2.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);
                file.CopyTo(target);

                string[] vectorFile = File.ReadAllLines(sourcePath);

                foreach (string vct in vectorFile)
                {
                    Console.WriteLine(vct);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("There was a problem with the file : " + e.Message);
            }
            */

            /* 2 - Using the StreamReader
             * 

            string sourcePath = @"//Users/silviocressoni/Documents/Studyies/DEV/C#/Text1.txt";

            StreamReader sr = null;

            try
            {
                using (sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string file = sr.ReadLine();
                        Console.WriteLine(file);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("There was a problem with the file : " + e.Message);
            }
            */


            string sourcePath = @"//Users/silviocressoni/Documents/Studyies/DEV/C#/Projects/HandleFiles/Text1.txt";
            string target = @"//Users/silviocressoni/Documents/Studyies/DEV/C#/Projects/HandleFiles/Text2.txt";

            try
            {
                string[] file = File.ReadAllLines(sourcePath);

                using (StreamWriter str = File.AppendText(target))
                {  
                    foreach (string stg in file)
                    {
                        str.WriteLine(stg.ToUpper());
                    }  
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
     }
}
