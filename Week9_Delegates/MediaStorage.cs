using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.  Say we have this class to store and manage various media files
// 2.  We want this class to be able to play the files to ensure they are valid
// 3.  This class does not need to know how to play the files, it just needs a code 
//     indicating whether the file played successfully. 
// 4.  We can use delegates to fulfill this role.  


namespace Week9_Delegates

{
    /// <summary>
    /// A class to manage the storage and manage various media files
    /// e.g.  Audio, Video, Animation 
    /// </summary>
    public class MediaStorage
    {

        // Declaration
        // access modifier - same as any other class
        // keyword delegate
        // Return type = any data type or void
        // Valid C# Name 
        // Parameters list
        // For our purposes -> Successfully played file = 0

        public delegate int PlayMedia();

        // A delegate does not have any method body.  
        // The method is not being defined.  
        // A delegate does not care what the method does or how it does it
        // As long as it has the right signature.

        // ----------------------

        // ReportResult looks likes any other method but it takes a playerDelegate parameter
        // Not an int but is a reference to a method.
        // Any method from any accessible class or struct that matches the 
        // delegate type (i.e returns an int and takes no parameters) can be assigned to the delegate.

        public void ReportResult(PlayMedia playerDelegate)
        {
            if(playerDelegate() == 0)
            {
                Console.WriteLine("Media played successfully");
            }
            else
            {
                Console.WriteLine("Media did not play. Corrupted file");
            }
        }

        
    }
}
