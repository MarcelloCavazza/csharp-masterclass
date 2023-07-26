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

            //HashTable Challenge
            //new HashTableChallenge();

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