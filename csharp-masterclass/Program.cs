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
            Box box = new Box(10,20,30);
            box.DisplayInfo();
            Console.WriteLine(box.FrontSurface);
            Console.ReadLine();
        }
    }
}
