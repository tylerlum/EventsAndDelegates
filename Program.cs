using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create video and encoder
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  // publisher

            // Create mail service
            var mailService = new MailService();  // subscriber

            // Subscribe by adding reference to mailService function
            // Note: no brackets
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            // Encode video
            videoEncoder.Encode(video);

            // Wait to show output
            Console.ReadLine();
        }
    }

    public class MailService
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
