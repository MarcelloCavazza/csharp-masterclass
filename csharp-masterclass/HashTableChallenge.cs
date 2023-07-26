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
            Student[] students = { 
                new Student(1, "Marcello"),
                new Student(2, "Pedro"),
                new Student(3, "Lucas"),
                new Student(4, "Paulo"),
                new Student(1, "Paulo"),
            };

            Hashtable SchoolHashTable = new Hashtable();

            foreach (Student student in students)
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


            foreach(Student student in SchoolHashTable.Values)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
            }



        }
    }
}
