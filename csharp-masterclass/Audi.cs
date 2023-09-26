using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Audi : Car
    {
        private string Model;
        private string brand   = "Audi";
        public Audi(int HP, int Color, string Model) : base(HP, Color)
        {
            this.Model = Model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("AUDI HP: {0}\nAUDI Color: {1}", this.CarHP, this.CarColor);
        }

        public new void Repair()
        {
            Console.WriteLine("AUDI was repaired!");
        }
    }
}
