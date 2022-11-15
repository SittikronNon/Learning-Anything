using System;
using System.Collections.Generic;

namespace PolymorphismC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3"),


            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "Black", "Z3");
            Car audiA3 = new Audi(100, "Green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1211, "Dizzien");
            audiA3.SetCarIDInfo(2235, "Cenlaroll");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "White", "A3");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Red", "M3 Twin turbo");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}
