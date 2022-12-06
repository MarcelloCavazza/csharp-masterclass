using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.Write("Enter a value");
            string rlInput = Console.ReadLine();
            Console.WriteLine("rlInput " + rlInput);

            Console.Write("Enter a value");
            int asciiInput = Console.Read();
            Console.WriteLine("asciiInput " + asciiInput);
            Console.ReadKey();
        }
    }
}
