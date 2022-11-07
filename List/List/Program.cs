using System;
using System.Collections;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(26);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(true);
            myArrayList.Add("sdfsdfsdfsdf");


            //Delete element with specific value from the arraylist
            myArrayList.Remove("Hello");

            //Delete element at specific position(index)
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } 
                else if(obj is double)
                {
                    sum += (double)obj;
                } 
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
