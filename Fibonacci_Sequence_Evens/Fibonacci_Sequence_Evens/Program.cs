using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci_Sequence_Evens
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, ab = 2;

            while (ab <= 4000000)
            {
                ab = a + b;
                a = b;
                b = ab;
                if (ab % 2 == 0)
                {
                    Console.WriteLine(ab);
                }
            }
        }
    }
}
