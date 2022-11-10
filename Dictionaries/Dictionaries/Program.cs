using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        //key = value
        //Auto(german) = car

        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            Console.WriteLine("Hello World!");
        }
    }

    class Employee 
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {

        }
    }
}
