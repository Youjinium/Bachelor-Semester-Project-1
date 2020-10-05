using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusCosinus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise
            float angle;
            Console.WriteLine("Enter value of angle");
            angle = float.Parse(Console.ReadLine());

            angle = angle * (float)Math.PI / 180;
            Console.WriteLine("Cosine: " + Math.Cos(angle));
            Console.WriteLine("Sinus: " + Math.Sin(angle));

        }
    }
}
