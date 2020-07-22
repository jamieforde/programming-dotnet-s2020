using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    // Another class subscribing to our event

    public class LogCurrentTime
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(WriteLogEntry);
        }

        public void WriteLogEntry(object theClock, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Logging to a file: {e.hour}:{e.minute:00}:{e.second:00}");
        }

    }
}
