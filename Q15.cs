using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number = number / 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine(originalNumber + "is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(originalNumber + " is not an Armstrong number.");
            }
        }
    }
}
