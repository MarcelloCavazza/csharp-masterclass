using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Human
    {
        private int age;

        private string firstName;
        private string lastName;

        public Human ()
        {
            Console.WriteLine("Created constructor");
        }

        public Human(string firstName, string lastName, int age) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void HelloMyWorld()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName} and I'm {age} years old");
        }
    }
}
