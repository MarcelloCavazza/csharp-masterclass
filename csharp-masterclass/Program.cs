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

            Students newStudents1 = new Students(1, "Marcello");
            Students newStudents2 = new Students(2, "Marcello");
            Students newStudents3 = new Students(3, "Marcello");
            Students newStudents4 = new Students(4, "Marcello");

            ht.Add(newStudents1.Id, newStudents1);
            ht.Add(newStudents2.Id, newStudents2);
            ht.Add(newStudents3.Id, newStudents3);
            ht.Add(newStudents4.Id, newStudents4);

            foreach(DictionaryEntry entry in ht)
            {
                Students temp = (Students)entry.Value;

                Console.WriteLine(temp.Id);
                Console.WriteLine(temp.Name);
            }


            foreach(Students value in ht.Values)
            {
                Console.WriteLine(value.Id);
                Console.WriteLine(value.Name);
            }



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