using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************************************
            /*    Exercise 1: Design a Stopwatch   *
            /***************************************
            Design a class called Stopwatch. 
            The job of this class is to simulate a stopwatch. 
            It should provide two methods: Start and Stop. We call the start method ﬁrst, and the stop method next. 
            Then we ask the stopwatch about the duration between start and stop.
            Duration should be a value in TimeSpan. Display the duration on the console.
            We should also be able to use a stopwatch multiple times. 
            So we may start and stop it and then start and stop it again.
            Make sure the duration value each time is calculated properly. 
            We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
            So the class should throw an InvalidOperationException if its started twice. 

            Educational tip: 
            The aim of this exercise is to make you understand that a class should be always in a valid state. 
            We use encapsulation and information hiding to achieve that. 
            The class should not reveal its implementation detail. 
            It only reveals a little bit, like a blackbox. 
            From the outside, you should not be able to misuse a class because you shouldn’t be able to see the implementation detail.             
            */

            const string exit = "EXIT";
            const string invalid = "INVALID";
            int input;
            TimeSpan result;
            // Start program
            do
            {
                do
                {
                    UserInterface.WelcomeScreen();
                    input = int.Parse(Console.ReadLine());
                    // EXIT
                    if (input == 9)
                    {
                        UserInterface.WelcomeScreen(exit);
                    }
                    // INVALID OPTION
                    else if (input != 1 && input != 9)
                    {
                        UserInterface.WelcomeScreen(invalid);
                    }
                } while (input != 9 && input != 1);

                // STOPPER STARTED
                if (input == 1)
                {
                    StopWatch.Start();
                    UserInterface.Started();

                    input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            StopWatch.Start();
                            break;
                        case 2:
                            result = StopWatch.Stop();
                            UserInterface.Result(result);
                            break;
                    }
                    Console.ReadLine();
                }


            } while (input != 9);


        }
    }
 }

