using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q21
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.WriteLine("\nThe series is: ");

            for (int i = 1; i <= terms; i++)
            {
                term = term * 10 + num;

                Console.Write(term);

                if (i < terms)
                    Console.Write(" + ");
                sum += term;
            }
            Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
