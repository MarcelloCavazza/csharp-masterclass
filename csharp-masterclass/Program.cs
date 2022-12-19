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
            Human marcello = new Human("Marcello", "Cavazza", 18);
            Human pedro = new Human();
            marcello.HelloMyWorld();
            Console.ReadLine();
        }
    }
}
