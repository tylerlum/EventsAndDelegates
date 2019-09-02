using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            // Send virtual mail
            Console.WriteLine("MailService: Sending an email...");
            Thread.Sleep(1000);
            Console.WriteLine("MailService: Email Sent!");
        }
    }
}
