using System;
using System.Collections.Generic;
namespace DelegatesDemo
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Between 20 and 30", people, filter);

            DisplayPeople("ALL", people, delegate (Person p) { return true; });


            string searchKeyword = "A";
            DisplayPeople("Age > 20 with search keyword" + searchKeyword, people, (p) =>
            {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            DisplayPeople("Exactly 25:", people, p => p.Age == 25);
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
