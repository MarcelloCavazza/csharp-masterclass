using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Car
    {
        private int HP;
        private int Color;

        public Car(int HP, int Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public int CarHP {
            get {
                return this.HP;
            }
            set 
            {
                this.HP = value;
            }
        }

        public int CarColor
        {
            get
            {
                return this.Color;
            }

            set
            {
                this.Color = value;
            }
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Car HP: {0}\nCar Color: {1}",this.HP, this.Color);
        }

        public void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
