using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_masterclass
{
    internal class Box
    {
        private int length;
        private int height;
        private int width;

        public Box(int length, int height, int width)
        {
            Length= length;
            Height= height;
            Width= width;
        }

        public int FrontSurface
        {
            get
            {
                return length * height;
            }
        }
        

        public int Volume
        {
            get
            {
                return this.length * this.height * this.width;
            }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Length is {length}, height is {height}, width is {width} so volume is {Volume}"
            );
        }
    }
}
