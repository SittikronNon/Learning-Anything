using System;
using System.Collections.Generic;

namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(1);
            Console.WriteLine("This was a List<int>");
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }



            Console.WriteLine("");
            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }


            Console.WriteLine("");
            unknownCollection = GetCollection(3);
            Console.WriteLine("This was an array of int");

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            //add values to the queue

            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
            {
                return numberList;
            }
            else if(option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

            
        }
    }
}
