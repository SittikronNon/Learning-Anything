using System;

namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reading Text
            string text = System.IO.File.ReadAllText(@"C:\Users\User\Desktop\c#\c#/textFile.txt");

            Console.WriteLine("Textfile contains following text: {0}", text);


            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\c#\c#/textFile.txt");
            Console.WriteLine("Contents of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
        }
    }
}
