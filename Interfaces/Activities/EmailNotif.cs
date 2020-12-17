using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces

{
    class EmailNotif : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email notification sent to owner of the video successfully");
            System.Threading.Thread.Sleep(5000);
        }

    }
}
