using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            //Ask for gender
            Console.WriteLine("Enter your gender (M/F):");
            char gender = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            string prefix;

            //Determine the prefix
            if (gender == 'M')
            {
                prefix = "Mr. ";
            }
            else if (gender == 'F')
            {
                prefix = "Ms. ";
            }
            else
            {
                Console.WriteLine("Invalid gender entered.");
                return;
            }

            //Display the name with prefix
            Console.WriteLine("Full Name:" + prefix + name);
        }
    }
}
