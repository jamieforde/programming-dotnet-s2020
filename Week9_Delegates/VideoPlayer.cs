using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Delegates
{
    public class VideoPlayer
    {
        private int videoPlayerStatus;

        public int PlayVideoFile()
        {
            Console.WriteLine("Simulating playing a video file here");
            videoPlayerStatus = -1;
            return videoPlayerStatus;
        }
    }
}
