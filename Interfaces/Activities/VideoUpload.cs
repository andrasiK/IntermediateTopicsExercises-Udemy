using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class VideoUpload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Video uploaded successfully");
            System.Threading.Thread.Sleep(5000);

        }
    }
}
