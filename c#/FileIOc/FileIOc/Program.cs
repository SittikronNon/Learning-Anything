using System;
using System.Threading.Tasks;
using System.IO;

namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Method 1
            string[] lines = { "First 252", "Second 242", "Third 240" };

            File.WriteAllLines(@"C:\Users\User\Desktop\c#\c#/highscore.txt", lines);

            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\User\Desktop\c#\c#/" + fileName + ".txt", input);
            */

            // Method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\User\Desktop\c#\c#/myText.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }    
                }
            }    

            using(StreamWriter file = new StreamWriter(@"C:\Users\User\Desktop\c#\c#/myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }




            // reading Text
           /*string text = System.IO.File.ReadAllText();

            Console.WriteLine("Textfile contains following text: {0}", text);


            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\c#\c#/textFile.txt");
            Console.WriteLine("Contents of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();*/
        }
    }
}
