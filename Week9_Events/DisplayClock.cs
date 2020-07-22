using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
    public class DisplayClock
    {

        /// <summary>
        /// Create a new SecondChangeHandler delegate
        /// Passing the event handler method
        /// </summary>
        /// <param name="theClock"></param>
        public void Subscribe(Clock theClock)
        {
            // += operator is the mechanism by which we classes can register their event handlers with the event. 
            theClock.SecondChanged += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        /// <summary>
        /// This is our event handler (i.e. this is what will be called when the event is raised)     
        /// Notice the method signature.
        /// </summary>
        /// <param name="theClock">The object that raised the event</param>
        /// <param name="e">Useful information about the event.  Here we store the time of the event</param>
        public void TimeHasChanged(object theClock, TimeInfoEventArgs e)
        {
            Console.WriteLine($"The time is {e.hour}:{e.minute:00}:{e.second:00}");
        }
    }
}
