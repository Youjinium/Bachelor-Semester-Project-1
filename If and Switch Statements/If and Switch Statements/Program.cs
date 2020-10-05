using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_and_Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 − NewGame");
            Console.WriteLine("2 − LoadGame");
            Console.WriteLine("3 − Options");
            Console.WriteLine("4 − Quit");
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine();

            Console.WriteLine("Please enter your choice");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("Creating new game ...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Loading game ...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Setting options ...");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Quitting ...");
            }
            else
            {
                Console.WriteLine("That's not a valid menu choice!");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating new game ...");
                    break;
                case 2:
                    Console.WriteLine("Loading game ...");
                    break;
                case 3:
                    Console.WriteLine("Setting options ...");
                    break;
                case 4:
                    Console.WriteLine("Quitting ...");
                    break;
                default:
                    Console.WriteLine("That's not a valid menu choice!");
                    break;

            }

            Console.WriteLine();
             







        }

        private static void NewMethod()
        {
            Console.WriteLine("Setting options ...");
        }
    }
}
