using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();

            if (mobileNumber.Length < 5)
            {
                Console.WriteLine("Mobile number is too short.");
                return;
            }
            string firstPart = mobileNumber.Substring(0, mobileNumber.Length - 5);

            string maskedNumber = firstPart + "XXXXX";
            Console.WriteLine("Masked mobile number: " + maskedNumber);
        }
    }
}
