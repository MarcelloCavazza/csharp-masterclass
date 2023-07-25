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
            Hashtable ht = new Hashtable();

            Students newStudents = new Students(1, "Marcello");
            
            Console.WriteLine(newStudents.Name);


            ht.Add(newStudents.Id, newStudents);

            Console.WriteLine(((Students)ht[1]).Id);
            Console.WriteLine(((Students)ht[1]).Name);

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