using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter a number between 1 and 100:");
            int Number = Convert.ToInt32(Console.ReadLine());


            // Processing
            if (Number % 2 != 0)
                Console.WriteLine("Odd.");

            else if (Number < 26)
                Console.WriteLine("Even and less than 25.");

            else if (Number < 61)
                Console.WriteLine("Even.");

            else
                Console.WriteLine("Even.");
        }
    }
}
