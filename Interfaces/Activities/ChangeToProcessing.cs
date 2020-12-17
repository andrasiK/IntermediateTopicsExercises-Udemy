using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ChangeToProcessing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status of the video set to 'Processing in the database'");
        }
    }
}
