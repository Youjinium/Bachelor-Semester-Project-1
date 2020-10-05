using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
     


            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

            Console.WriteLine();
            // Exercise
            int score = 1360;
            int played = 10000;

            float pointsPerSecond = score / (float)played;
            Console.WriteLine("Points per Second: " + pointsPerSecond);

            Console.WriteLine();
            // Exercise
            double cosine = (double)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine);

            Console.WriteLine();

            // Exercise
            float angle;
            Console.WriteLine("Enter value of angle");
            angle = float.Parse(Console.ReadLine());

            angle = (float)Math.PI * 180;
            Console.WriteLine("Cosine: " + Math.Cos(angle));
            Console.WriteLine("Sinus: " + Math.Sin(angle));









        }
    }
}
