using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(10000);
            Console.WriteLine("Encoding complete!");
        }
    }
}
