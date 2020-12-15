using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
        public static class StopWatch
        {
            private static DateTime start;
            private static bool isStarted = false;
            private static DateTime stop;
            private static TimeSpan result;

            public static TimeSpan Result { get; }

            public static void Start()
            {
                try
                {
                    if (isStarted)
                    {
                        throw new InvalidOperationException("\t\t\t ERROR : STOPWATCH ALREADY STARTED ");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;

                }

                start = DateTime.Now;
                isStarted = true;
            }

            public static TimeSpan Stop()
            {
                stop = DateTime.Now;
                result = stop - start;
                isStarted = false;
                return result;
            }
        }
}
