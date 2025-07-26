using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class logic
    {
        static void Main()
        {
            PrintPattern(3); // prints 3-block
            Console.WriteLine(); // space
            PrintPattern(4); // prints 4-block
        }

        static void PrintPattern(int center)
        {
            // Top row
            Console.WriteLine($"{center}{center}{center}");

            // Middle rows
            for (int i = center - 1; i <= center + 1; i++)
            {
                Console.WriteLine($"{center}{i}{center}");
            }

            // Bottom row
            Console.WriteLine($"{center}{center}{center}");
        }
    }
}


