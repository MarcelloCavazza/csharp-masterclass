using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Program
    {
        static int age = 18;
        static void Main(string[] args)
        {
            if(age < 18)
            {
                Console.WriteLine("He/she is not an adult!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("He/she is an adult!");
                Console.ReadLine();
            }
        }
    }
}
