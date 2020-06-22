using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassesAndObjectsDeeperLook
{
    public static class Time2ExtensionMethods
    {
        public static Time2 AddHours(this Time2 aTime, int hours)
        {
            var newTime = new Time2()
            {
                Minute = aTime.Minute,
                Second = aTime.Second
            };

            newTime.Hour = (aTime.Hour + hours) % 24;

            return newTime;
        }
    }
}
