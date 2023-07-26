using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            Id= id;
            Name= name;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        ~Student()
        {
            Console.WriteLine("Closing Class");
            Debug.Write("Closing Class");
        }
    }
}
