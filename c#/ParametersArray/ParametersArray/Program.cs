using System;

namespace ParametersArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = {12, 23, 43, 23, 50};
            GetAverage(happiness);

            foreach (int x in happiness)
            { 
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }


        static void GetAverage(int[] happyArray)
        {
            for(int i = 0; i < happyArray.Length; i++)
            {
                happyArray[i] += 2;
            }
            
        }
    }
}
