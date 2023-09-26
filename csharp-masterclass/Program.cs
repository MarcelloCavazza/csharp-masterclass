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

            //Student[] students = {
            //    new Student(1, "Marcello"),
            //    new Student(2, "Pedro"),
            //    new Student(3, "Lucas"),
            //};

            //Student[] students = {
            //    new Student(6565, "Marcello"),
            //    new Student(784, "Pedro"),
            //    new Student(24, "Lucas"),
            //};

            //Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>();

            //foreach(Student student in students)
            //{
            //    studentsDictionary.Add(student.Id, student);
            //}


            //for (int i = 0; i < studentsDictionary.Count; i++)
            //{
            //    KeyValuePair<int, Student> keyValuePair = studentsDictionary.ElementAt(i);

            //    Console.WriteLine(keyValuePair.Key);
            //    Console.WriteLine(keyValuePair.Value.Id);
            //    Console.WriteLine(keyValuePair.Value.Name);
            //}

            //Student result;



            //if(studentsDictionary.TryGetValue(784, out result))
            //{
            //    Console.WriteLine(((Student)result).Name);
            //}

            Audi a = new Audi(10, 7575, "Sport");

            a.ShowDetails();
            a.Repair();


            Car b = new Audi(10, 7575, "Sport");

            b.ShowDetails();
            b.Repair();

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