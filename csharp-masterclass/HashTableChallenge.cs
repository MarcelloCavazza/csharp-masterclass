using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class HashTableChallenge
    {
        public HashTableChallenge() {
            Students[] students = { 
                new Students(1, "Marcello"),
                new Students(2, "Pedro"),
                new Students(3, "Lucas"),
                new Students(4, "Paulo"),
                new Students(1, "Paulo"),
            };

            Hashtable SchoolHashTable = new Hashtable();

            foreach (Students student in students)
            {
                if (SchoolHashTable.ContainsKey(student.Id))
                {
                    Console.WriteLine($"Sorry, A student with the Id {student.Id} already registered.");
                }
                else
                {
                    SchoolHashTable.Add(student.Id, student);
                    Console.WriteLine($"Student with the Id {student.Id} was added.");

                }
            }


            foreach(Students student in SchoolHashTable.Values)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
            }



        }
    }
}
