using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Exception classes are derived from the class Exception -> This is a great example of Inheritance
 * Exception Properties:
    * Message:  Stores a string error message for the exception object.
    * StackTrace:  A string representation of the method-call stack
    * InnerException:  Is an exception that caused the current exception.  
        It is conveinent way to copy the details of an exception.  
    * HelpLink:  Specifies a link to the help file that describes the problem
    * Source:  Specifies the assembly that caused the exception
    * TargetSite: specifies the method where the exception originated
*/

namespace Week5_ExceptionProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            } catch (Exception exceptionParameter)
            {
                Console.WriteLine($"exceptionParameter.ToString():\n\t {exceptionParameter}");
                Console.WriteLine($"exceptionParameter.Message:\n\t {exceptionParameter.Message}");
                Console.WriteLine($"exceptionParameter.StackTrace:\n\t {exceptionParameter.StackTrace}");
                Console.WriteLine($"exceptionParameter.InnerException:\n\t {exceptionParameter.InnerException}");               
            } finally
            {
                Console.WriteLine("Remember the finally always executes.");
            }

            Console.ReadKey();
        }

        static void Method1() =>  Method2();
            
        static void Method2()
        {
            Method3();
        }

        static void Method3()
        {
            try
            {
                int.Parse("This is not an integer");
            }
            catch (FormatException formatException)
            {
                throw new Exception("Exception Occured in Method 3", formatException);
            }
        }
    }
}
