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

            // Create mail and message service
            var mailService = new MailService();  // subscriber
            var messageService = new MessageService();  // subscriber

            // Subscribe by adding reference to mailService function
            // Note: no brackets
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            // Encode video
            videoEncoder.Encode(video);

            // Wait to show output
            Console.ReadLine();
        }
    }


}
