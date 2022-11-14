using System;

namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee michale = new Employee("Michale", "Miller", 40000);

            michale.Work();
            michale.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 998998);

            chuckNorris.Lead();

            Trainees michelle = new Trainees(32, 8, "Garner", "Michelle", 10000);
            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
