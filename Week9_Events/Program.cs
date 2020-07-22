using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Events
{
 /* Events
 * Event is a message sent by an object to signal the occurence of an action
 * Action can be caused by user interaction or can be a result from some other 
 * program logic
 * The object that raises an event is call the event sender. 
 * The event sender does not know which which object or method that will receive
 * (handle) the event it raises.
 * 
 * Publishing and Subscribing   
 * An event sender can publish a set of events to which other classes can subscribe
 * That is when the publishing class raises an event all the subscribing classes are 
 * notified. 
 * The advantages of this approach are:
    * The publishing class does not need to know how it's information will be used
    * Any number of classes can be notified of the event
    * Subscribing class do not need to know how the publishing class works
    * Publishing class does not need to know what the subscribing class is going to do
    * in response to the event.
    * Subscribing class do not need to know about each other
    * We decouples classes that produce events from services that process events.
 * In the .NET framework events are implemented with delegates. 
 * Need three components:
    * Publishing class defines a delegate
    * Subscribing class creates a method that matches the signature of the delegate and 
    * creates a an instance of that delegate type encapsulating that method.
    * When the event is raised the subscribing class's methods are invoked through
    * the delegate. 
*/

    class Program
    {
        static void Main(string[] args)
        {
            Clock theClock = new Clock();

            // Create a display object and tell it to subscribe to the clock
            DisplayClock displayClock = new DisplayClock();
            displayClock.Subscribe(theClock);

            // Create a log object and tell it to subscribe to the clock 
            LogCurrentTime logCurrentTime = new LogCurrentTime();
            logCurrentTime.Subscribe(theClock);

            // Start the clock
            theClock.Run();
        }
    }
}
