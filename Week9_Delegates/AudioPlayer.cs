using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Delegates
{
    public class AudioPlayer
    {
        private int audioPlayerStatus;

        /// <summary>
        /// Simulates playing an audio file
        /// </summary>
        /// <returns>An integer representing a status code.  0 = success</returns>
        /// Note as this method has the proper signature it can be used with the delegate

        public int PlayAudioFile()
        {
            Console.WriteLine("Simulating playing an audio file");
            audioPlayerStatus = 0;
            return audioPlayerStatus;
        }

        public decimal AlternativePlayer()
        {
            return 1.1M;
        }
    }
}
