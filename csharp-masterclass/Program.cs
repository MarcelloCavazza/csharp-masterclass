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
            Students[] students = new Students[5];
            Hashtable studdentsHashtable = new Hashtable();

            students[0] = new Students(1, "Pedro");
            students[1] = new Students(2, "Lucas");
            students[2] = new Students(1, "Felipe");
            students[3] = new Students(4, "Sergio");
            students[4] = new Students(4, "Caio");

            foreach (Students student in students)
            {
                Boolean studentAlreadyExists = studdentsHashtable.ContainsKey(student.Id);
                if(studentAlreadyExists)
                {
                    Console.WriteLine("Student Id already being used!");
                    continue;
                }
                studdentsHashtable.Add(student.Id, student);
            }
            Console.WriteLine("Usuarios criados:");

            foreach (Students entry in studdentsHashtable.Values)
            {
                Console.WriteLine("Nome: {0}", entry.Name);
            }
            Console.ReadLine();

        }
    }
}