using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            // Send virtual mail
            Console.WriteLine($"MailService: Sending an email for {e.Video.Title}...");
            Thread.Sleep(1000);
            Console.WriteLine($"MailService: Email Sent for {e.Video.Title}!");
        }
    }
}
