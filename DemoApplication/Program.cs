using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DemoApplication
{
    public class Program
    {
        // https://projecteuler.net/problem=52

        // It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
        // Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.

        static void Main(string[] args)
        {
            Console.WriteLine("Starting search...");

            for (uint i = 1; i < PermutedMultiples.MaxThreshold; i++)
            {
                if (PermutedMultiples.IsMatching(i))
                {
                    Console.WriteLine(String.Format("The smallest positive integer is: {0}", i));
                    break;
                }
            }

            Console.WriteLine("Finished search.");
            Console.ReadLine();
        }


    }
}
