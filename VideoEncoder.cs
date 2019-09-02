using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Setup event handler
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            // Encode Video
            Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding complete!");

            // "Publish"
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            // Check if there are any subscribers
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
