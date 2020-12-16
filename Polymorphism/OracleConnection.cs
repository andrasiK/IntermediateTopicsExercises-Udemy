using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class OracleConnection : DbConnection
    {

        public OracleConnection(string s) : base(s)
        {

        }



        public override void OpenDbConnection()
        {
            var timeOut = false;
            try
            {
            //implement a timeout just to try out
              DateTime startTime = DateTime.Now;
                
              MethodToWait();

               if (DateTime.Now.Subtract(startTime).TotalMilliseconds > 5000)
               {
                    throw new TimeoutException();
               }
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Connection timeout!");
                timeOut = true;
            }

            if (timeOut == false)
            {
                Console.WriteLine("Oracle database connection opened");
            }
            
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Oracle database connection closed");
        }


        private void MethodToWait()
        {
            System.Threading.Thread.Sleep(6000);
        }
    }
}
