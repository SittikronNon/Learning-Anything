using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Amatoli" };

            Console.WriteLine("-----before-----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        
            names.RemoveAll(Filter);

            Console.WriteLine("-----after-----");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            
        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}
