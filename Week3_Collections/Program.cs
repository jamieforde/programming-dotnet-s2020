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
            var names = new List<string>(100) { "Frodo", "Gandalf", "Bilbo", "Gimli" };
            
            Console.WriteLine($"List Count:  {names.Count}");
            Console.WriteLine($"List Capacity: {names.Capacity}");

            names.Add("Samwise");
            DisplayNames(names);

            names.Insert(0, "Gollum");
            DisplayNames(names);

            names.Remove("Gimli");
            DisplayNames(names);

            names.RemoveAt(0);
            DisplayNames(names);


            Console.WriteLine($"Does the List have Gimli: {names.Contains("Gimli")}");

            names.TrimExcess();
            Console.WriteLine($"List Capacity: {names.Capacity}");

            var namesOrdered =
                from name in names
                orderby name descending
                select name;

            var filterNames =
                from name in names
                let upperName = name.ToUpper()
                where upperName.StartsWith("G")
                select upperName;

            foreach(var name in filterNames)
            {
                Console.WriteLine(name);
            }


            //foreach (var name in namesOrdered)
            //{
            //    Console.WriteLine(name);
            //}


            Console.ReadKey();
       
        }

        public static void DisplayNames(List<string> names)
        {
                 Console.WriteLine(string.Join(",", names));
        }
    }
}
