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

            int age = 18;
            string name = "Marcello";
            string finalString = $"       My name is {name} I'm {age} years old.";
            Console.WriteLine(finalString.Trim().Substring(2,5));
            Console.WriteLine(finalString.ToUpper());
            Console.WriteLine(finalString.ToLower());
            Console.WriteLine(finalString.IndexOf("Marcello"));

            Console.ReadKey();
        }
    }
}
