using System;
using System.Collections.Generic;

namespace stacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stacks
            //define a new stack
            Stack<int> stack = new Stack<int>();
            stack.Push(20);
            stack.Push(22);
            stack.Push(23);

            Console.WriteLine("Peek will return element at the top without removing it and it is {0}", stack.Peek());
            stack.Pop();
            Console.WriteLine("New Peek element from Pop is : {0} ", stack.Peek());

            //it is good to note that before you pop the stack since it can cause you an error!
            while(stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());

                Console.WriteLine("Current stack count is : {0}", stack.Count);

            }

            int[] numbers = new int[] { 8, 4, 5, 1, 2, 90, 23, 54 };

            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("the numbers in the aray are :");

            foreach(int number in numbers)
            {
                Console.Write(number + " ");

                myStack.Push(number);
            }
            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse : ");

            while(myStack.Count > 0)
            {  
                Console.Write("{0} ", myStack.Pop());
            }
            Console.WriteLine(" ");





            //Queues
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The Queues is : {0}",queue.Peek());
            queue.Enqueue(2);
            int queueItem = queue.Dequeue();
            Console.WriteLine("The Queues is : {0}", queue.Peek());
            queue.Enqueue(3);
            queue.Enqueue(4);
            //note. . . same as stack about error when dequeueing

            while(queue.Count > 0)
            {
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());

                Console.WriteLine("Current queue count is : {0}", queue.Count);
            }

        }
    }
}
