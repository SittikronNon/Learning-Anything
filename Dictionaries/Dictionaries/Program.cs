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
            Employee[] employees =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("HR","Lora",35,25),
                new Employee("Manager","Joe",32,21),
                new Employee("SEA","Non",45,200),
                new Employee("SEO","Nick",100,98),
                new Employee("SE","Mind",45,200),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            string key = "SEAa";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["SEA"];

                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key '{0}'", key);
            }

            Employee result = null;
            if (employeesDirectory.TryGetValue("CEO", out result))
            {
                Console.WriteLine("Value Retrieved!.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Name: {0}", result.Role);
                Console.WriteLine("Employee Name: {0}", result.Age);
                Console.WriteLine("Employee Name: {0}", result.Salary);

            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

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
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
