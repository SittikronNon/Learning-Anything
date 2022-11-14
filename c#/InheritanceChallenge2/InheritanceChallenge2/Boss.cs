using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Boss :Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary):base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;


        }

        public void Lead()
        {
            Console.WriteLine("I'm the boss. My name is {0} {1} my salary is {2}", Firstname, Name, Salary);
        }
    }
}
