using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Week10_GenericCollectionIntro.CarComparer;

namespace Week10_GenericCollectionIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Collection

            List<Car> cars = new List<Car>
            {
                new Car { Make = "Toyota", Model = "Prius", Year = 2016 },
                new Car { Make = "Dodge", Model = "Viper", Year = 2020 },
                new Car { Make = "Ford", Model = "Mustang", Year = 1969 }
            };

            cars.Sort();

            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }

            CarComparer carComparer = Car.GetComparer();
            carComparer.WhichComparison = ComparisonType.Make;
            cars.Sort(carComparer);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
