using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T>
            // Does not need to be reallocated to change its size
            // Generic class - can be used with any object.
            // We specify the type parameter in <>
            // Do not worry about the specifics of Generics we cover this in later in the 
            // course.  

            // Collection Intitializers
            // Remember List is a class so you need to instantiate it. 
            var names = new List<string>(100) { "Frodo", "Gandalf", "Bilbo", "Gimli" };

            // Properties 
            // Count - number of elements in the List
            Console.WriteLine($"List Count:  {names.Count}");

            // Capacity - the number of elements a List can contain before resizing.
            // This can be set in the constructor by passing an integer parameter.
            Console.WriteLine($"List Capacity: {names.Capacity}");

            // Methods
            // Add - appends to the end of the List
            Console.WriteLine("/nAdd method - Adding Samwise");
            names.Add("Samwise");
            DisplayNames(names);

            // Insert - Inserts a new element at the specified position
            Console.WriteLine("/nInsert method - Adding Gollom");
            names.Insert(0, "Gollum");
            DisplayNames(names);

            // Remove - removes the first instance of an element
            Console.WriteLine("/nRemoved method");
            names.Remove("Gimli");
            DisplayNames(names);

            // RemoveAt - removes the element at specified index
            Console.WriteLine("/nRemove at method");
            names.RemoveAt(0);
            DisplayNames(names);

            // Contains - returns true if element is found 
            Console.WriteLine($"Does the List have Gimli: {names.Contains("Gimli")}");

            // TrimExcess - Sets the Capacity of the list to its count.
            names.TrimExcess();
            Console.WriteLine($"List Capacity: {names.Capacity}");

            // LINQ queries are structured the exact same as with arrays
            var namesOrdered =
                from name in names
                orderby name descending
                select name;

            // The let keyword allows us to redefine a second range variable.   
            // Which we can use in the query.

            // Note:  LINQ has a deferred execution so the query is not executed until it is used
            // NOT when it is defined
            // ToList is an extension method that returns the result of the query immediately. 

            // Note:  That to get the result of the query into a List it is wrapped in parentheses.  
            var filterNames =
                (from name in names
                let upperName = name.ToUpper()
                where upperName.StartsWith("G")
                select upperName).ToList();

            DisplayNames(filterNames);

            Console.ReadKey();      
        }

        /// <summary>
        /// Helper method to display input of a List<string>
        /// </summary>
        /// <param name="names"></param>
        public static void DisplayNames(List<string> names)
        {
                 Console.WriteLine(string.Join(",", names));
        }
    }
}
