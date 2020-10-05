using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion from Fahrenheit to Celsius
            Console.WriteLine("Enter Temperature in Fahrenheit");
            float fahrenheit = float.Parse(Console.ReadLine());

            float celsius = ((fahrenheit - 32) / 9) * 5;
         
            Console.WriteLine("Temperature in Celsius is: " + celsius + "°C");
            Console.WriteLine();

            //Conversion from Celsius to Fahrenheit
            Console.WriteLine("Enter Temperature in Celsius");
            float celsius1 = float.Parse(Console.ReadLine());

            float fahrenheit1 = ((celsius1 * 9) / 5) + 32;

            Console.WriteLine("Temperature in Celsius is: " + fahrenheit1 + "°F");
            Console.WriteLine();

        }
    }
}
