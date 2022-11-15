using System;

namespace AbstractClassesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape a cube");
                }
            }

        }
    }
}
