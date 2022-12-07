using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            string userName;
            Console.WriteLine("Please enter your name and press enter");
            userName = Console.ReadLine();
            Console.WriteLine("UpperCase"+userName.ToUpper());
            Console.WriteLine("Lowercase" + userName.ToLower());
            Console.WriteLine("Trim" + userName.Trim());
            Console.WriteLine("Substring" + userName.Substring(2));

            Console.ReadKey();
        }
    }
}
