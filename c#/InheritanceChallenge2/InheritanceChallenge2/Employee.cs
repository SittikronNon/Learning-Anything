using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        protected string Name { get; set; }

        protected string Firstname { get; set; }

        protected int Salary { get; set; }

        public Employee()
        {
            Name = "Dizz";
            Firstname = "Dizzien";
            Salary = 50000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.Firstname = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I am working!");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
