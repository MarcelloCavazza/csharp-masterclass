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
            int num = 999;
            long bignum = num;

            float myfloat = 13.37f;
            double myNewDouble = myfloat;

            Console.WriteLine(bignum);
            Console.WriteLine(myNewDouble);

            Console.WriteLine("myfloat"+ myfloat.ToString());
            Console.WriteLine(myNewDouble);


            //explicit conversion
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            Console.ReadKey();
        }
    }
}
