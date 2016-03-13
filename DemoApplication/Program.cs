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
            // stop at anything greated ther int.MaxValue as this would cause OverflowException
            for (uint i = 1; i < int.MaxValue; i++)
            {
                if (PermutedMultiples.IsMatching(i))
                {
                    break;
                }
            }
        }


    }
}
