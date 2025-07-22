using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            for (int i= 0; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                 Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }

        }
    }
}
