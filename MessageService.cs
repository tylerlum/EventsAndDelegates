using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a message for {e.Video.Title}...");
            Thread.Sleep(2000);
            Console.WriteLine($"MessageService: Message sent for {e.Video.Title}!");
        }
    }
}
