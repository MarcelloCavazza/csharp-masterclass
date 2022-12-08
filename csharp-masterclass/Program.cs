using System;
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

            //string word;
            //char charToSearch;
            //Console.WriteLine("Please enter a word:");
            //word = Console.ReadLine();
            //Console.WriteLine("Please enter a character to search:");
            //charToSearch = char.Parse(Console.ReadLine());
            //Console.WriteLine("IndexOf: " + word.IndexOf(charToSearch));

            string firstName, secondName;
            Console.WriteLine("Put your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Put your last name");
            secondName = Console.ReadLine();
            if(firstName.Length > 0 && secondName.Length > 0) {
                string fullName = $"{firstName} {secondName}";
                Console.WriteLine(fullName);
            }
            else
            {
                Console.WriteLine("Any name can be empty!");
            }

            Console.ReadKey();
        }
    }
}
