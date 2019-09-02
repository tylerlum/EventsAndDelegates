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
        // Setup delegate and event
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            // Encode Video
            Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding complete!");

            // "Publish"
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            // Check if there are any subscribers
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
