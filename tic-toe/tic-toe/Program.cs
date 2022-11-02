using System;

namespace tic_toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetField();
            Console.ReadKey();
            
        }

        public static void SetField()
        {
            Console.WriteLine("    |   |   ");
            Console.WriteLine("  {0}    |   {1} |   {2}",1,2,3);
            Console.WriteLine("____|____|____");
        }
    }
}
