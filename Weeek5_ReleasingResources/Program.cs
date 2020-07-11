using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeek5_ReleasingResources
{
    class Program
    {
        /* Programs frequently request resoucres dynamically (at runtime)
         * We explored this in File I/O section when working with files
         * It best practice to release such resources when we have finished working with them 
         * Not releasing resource such as file can cause resource leaks
         * C# exception handling mechanism provides the finally block to allow resources to be
         * released when an try block succeeds or fails (throw an exception)
         * A finally block is always executed
         
         * In this example we are attempting to read in a file
         * We can investigate what exceptions a StreamReader may generate using
         * the Object Browser.  Access View-> Object Browser from file menu
        */

        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            var continueLoop = true;
            do
            {
                try
                {
                    Console.WriteLine("Enter a file path:");
                    var path = Console.ReadLine();
                    streamReader = new StreamReader(path);
                    Console.WriteLine("StreanReader was successfully executed!");
                    continueLoop = false;
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine($"{argumentException.Message}");
                    Console.WriteLine("The path cannot be empty string");
                }
                catch (IOException ioException)
                {
                    Console.WriteLine($"{ioException.Message}");
                    Console.WriteLine($"File or Directory not found");
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{ exception.Message}");
                    Console.WriteLine("General Error");
                }

                // This block is always executed if an exception occurs or not.  
                finally
                {
                    Console.WriteLine($"Finally always executes");

                    // NOTE:   The null conditional operator ?.
                    // If an exception is thrown at line 32 the streamReader is never instatiated.
                    // That is it is null
                    // So if we do not check streamReader has a reference this will through 
                    // an exception.  
                    // We could check with:
                    // if (streamReader != null) - the null conditional operator is shortcut. 
                    // and I think more readable

                    streamReader?.Close();
                }
            } while (continueLoop);
            Console.WriteLine();
        }
    }
}
