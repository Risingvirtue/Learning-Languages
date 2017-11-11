using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            var anotherName = "Tom";
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: {0}",  rand.Next(1, 11));
        }
    }
}
