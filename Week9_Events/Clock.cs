using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week9_Events
{
    // Create a clock class that uses delegates to notify 
    // potential subscribers whenever the time changes it values by one second.

    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

    /* Delegate will encapsulate any method that returns void and takes two parameters
    *  Object that represents the clock
    * Eventargs - that will contain useful information for anyone interested in the event.
    * This is the delegate subscribers must implement
    */

        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);

    // An instance of the delegate
    // Notice keyword events -> prevents issues (see slides)
        public event SecondChangeHandler SecondChanged;

        public void Run()
        {
            // infinite loop
            while(true)
            {
                // Chill here 100 microseconds.
                Thread.Sleep(100);

                DateTime dateTime = DateTime.Now;

                // Check if the second has changed
                if (dateTime.Second != this.second)
                {
                    // Check if anyone has subscribed to this event 
                    if (SecondChanged != null)
                    {
                        TimeInfoEventArgs timeInformation = 
                            new TimeInfoEventArgs(dateTime.Hour, dateTime.Minute, dateTime.Second);

                        // Execute the delegate  
                        SecondChanged(this, timeInformation);
                    }
                }

                //Update the state of the clock
                this.second = dateTime.Second;
                this.minute = dateTime.Minute;
                this.hour = dateTime.Hour;
            }
        }
    }
}
