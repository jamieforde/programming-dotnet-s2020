using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_Delegates
{
    // A delegate is special type of object that holds a reference to a method
    // It gives a name to a method signature or more fancy it 
    // encapsulates a method signature.

    // Benefits
    // Object orientated and type-safe we can ensure that the correct method type is 
    // is called (see line 46).  Allows us to pass methods as parameters. 
    // Decouple the class that declares the delegate from the class
    // that uses the delegate.

    // CONCLUSION
    // At compile time ReportResult does not know (or care) which method it is 
    // going to call 
    // It only finds out at runtime.  
    // All it needs to know is that any method it will be asked to call 
    // will match the signature fefined by the PlayMedia delegate. 
    // The power of delegates is that we can pass them as parameters in other
    // methods, which makes them ideal for defining callback methods.

    class Program
    {
        static void Main(string[] args)
        {
            // Instatiate the MediaStorage class 
            // and each of the media players
            MediaStorage myMediaStorage = new MediaStorage();
            AudioPlayer myAudioPlayer = new AudioPlayer();
            VideoPlayer myVideoPlayer = new VideoPlayer();

            // Instantiate the delegates
            MediaStorage.PlayMedia audioPlayerDelegate = new MediaStorage.PlayMedia(myAudioPlayer.PlayAudioFile);
            MediaStorage.PlayMedia videoPlayerDelegate = new MediaStorage.PlayMedia(myVideoPlayer.PlayVideoFile);

            // If you uncomment the below line of code you will get a compiler error.
            // We are trying to encapsulate a method that does not match the signature of the delegate.
            //MediaStorage.PlayMedia alternativeDelegate = new MediaStorage.PlayMedia(myAudioPlayer.AlternativePlayer);

            // Delegates are used with the ReportResult() method to see if the media
            // files are valid.
            myMediaStorage.ReportResult(audioPlayerDelegate);
            myMediaStorage.ReportResult(videoPlayerDelegate);

            Console.ReadKey();
        }
    }
}
