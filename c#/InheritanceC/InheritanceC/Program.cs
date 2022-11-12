using System;

namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birth day wishes", true, "Dizzien");
            Console.WriteLine(post1.ToString());
            

            ImagePost imagePost1 = new ImagePost("Check out my new book", "Dizzien", "http//:images/com", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
