using System;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\c#\c#\input.txt");

            using(StreamWriter file = new StreamWriter(@"C:\Users\User\Desktop\c#\c#\output.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("split"))
                    {
                        file.WriteLine(line.Split(" ")[4]);
                    }
                }
            }
            
            
        }
    }
}
