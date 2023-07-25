using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Students
    {
        private int id;
        private string name;

        public Students(int id, string name)
        {
            Id= id;
            Name= name;
        }
        public Students()
        {
            Console.WriteLine("HELLO");
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

        ~Students()
        {
            Console.WriteLine("Hello");
            Debug.Write("Hello");
        }
    }
}
