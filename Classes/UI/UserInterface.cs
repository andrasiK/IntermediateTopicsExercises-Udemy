using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class UserInterface
    {
        public static void WelcomeScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t*** Welcome to the stopwatch application! *** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t 1 - Start stopwatch");
            Console.WriteLine("\t\t\t 9 - Exit application");
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void WelcomeScreen(string inp)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t*** Welcome to the stopwatch application! *** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t 1 - Start stopwatch");
            Console.WriteLine("\t\t\t 9 - Exit application");
            Console.WriteLine();
            Console.WriteLine();
            if (inp == "INVALID")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t INVALID OPTION");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (inp == "EXIT")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t THE PROGRAM EXITS");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadLine();



        }

        public static void Started()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t*** Welcome to the stopwatch application! *** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t Please choose an option:");
            Console.WriteLine("\t\t\t 1 - Start stopwatch");
            Console.WriteLine("\t\t\t 2 - Stop stopwatch");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t STOPWATCH STARTED");
            Console.ForegroundColor = ConsoleColor.White;


        }

        public static void Result(TimeSpan r)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t*** Welcome to the stopwatch application! *** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t The result is: {0} ", r);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t Press ENTER");

        }

    }
}

