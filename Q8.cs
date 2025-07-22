using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Q8
    {
        static void Main(string[] args)
        {
            // Declaring String
            string s1 = "John F Kennedy";

            // Convert string to uppercase
            string s2 = s1.ToUpper();

            //Printing the lowercase to uppercase
            Console.WriteLine("String Before Uppercase:" + s1);
            Console.WriteLine("String After Uppercase:" + s2);
        }
    }
}
