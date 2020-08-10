using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> provinceCapitals = new Dictionary<string, string>();

            provinceCapitals.Add("Alberta", "Edmonton");
            provinceCapitals.Add("British Columbia", "Victoria");
            provinceCapitals.Add("Manitoba", "Winnipeg");
            provinceCapitals.Add("New Brunswick", "Fredericton");
            provinceCapitals.Add("Newfoundland", "St. John's");
            provinceCapitals.Add("Northwest Territories", "Yellowknife");
            provinceCapitals.Add("Nova Scotia", "Halifax");
            provinceCapitals.Add("Nunavut", "Iqaluit");
            provinceCapitals.Add("Ontario", "Toronto");
            provinceCapitals.Add("Prince Edward Island", "Charlottetown");
            provinceCapitals.Add("Quebec", "Quebec City");
            provinceCapitals.Add("Saskatchewan", "Regina");
            provinceCapitals.Add("Yukon", "Whitehorse");

            Console.WriteLine($"Capital of Ontario is {provinceCapitals["Ontario"]}");

            provinceCapitals.Remove("Quebec");

            foreach(var kvp in provinceCapitals)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value}");
            }

            Console.ReadKey();



        }
    }
}
