using System;
using System.Collections;
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

            //ConsoleWriteLine(1, 2, 3, "a", "b");

            //Students students = new Students(12, "Pedro");

            Console.WriteLine(MinV2(100023, 99, 2222,  900));


            //int[] number = { 1, 2, 3, 4, 5, 6 };

            //foreach (int i in number)
            //{
            //    ConsoleWriteLine(i);
            //}


            Console.ReadLine();
        }


        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach(int number in numbers)
            {
                if (number < min) min = number;
            }

            return min;
        }

        public static string ConsoleWriteLine(params object[] input)
        {
            foreach (object o in input) Console.WriteLine(o);
            return "";
        }
    }
}