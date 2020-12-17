using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces 
{
    class CallEncodingService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling encoding webservice...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Call successfull");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
