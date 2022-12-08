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

            byte bVar = 255;
            sbyte sVar = -128;
            int iVar = 2147483647;
            short stVar = 32767;
            float fVar = 3.402823e38f;
            double dVar = 130823.232;
            char cVar = 'c';
            bool blVar = false;
            decimal dlVar = 1028m;

            string phrase1 = "I control text", phrase2 = "23232";
            int phrase2AsInt = int.Parse(phrase2);

            Console.ReadKey();
        }
    }
}
