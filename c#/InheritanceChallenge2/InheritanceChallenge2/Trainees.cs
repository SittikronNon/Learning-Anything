using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Trainees : Employee
    {
        protected int WorkingHours { get; set; }

        protected int SchoolHours { get; set; }

        public Trainees(int workingHours, int schoolHours, string name, string firstName, int salary) : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm currently learning right now!");
        }

        public void Work()
        {
            Console.WriteLine("I work for {0} hours", WorkingHours);
        }
    }
}
