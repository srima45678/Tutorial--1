using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q22
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Upper half of diamond
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);            // spaces before stars
                string stars = new string('*', 2 * i - 1);         // stars in row
                Console.WriteLine(spaces + stars);                 // print the full row
            }

            // Lower half of diamond
            for (int i = n - 1; i >= 1; i--)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }
    }
}
