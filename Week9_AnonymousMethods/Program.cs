using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week9_AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            cars.Add(new Car { Make = "Ford", Model = "F150", Year = 2020 });
            cars.Add(new Car { Make = "Tesla", Model = "Model X", Year = 2018 });
            cars.Add(new Car { Make = "Dodge", Model = "Viper", Year = 2006 });

            //Step 2 - Declared delegate
            Predicate<Car> carPredicate = new Predicate<Car>(FindCar);

            //Step 3 - Using the delegate
            var teslaCar = cars.Find(carPredicate);

            Console.WriteLine(teslaCar);

            var fordCar = cars.Find(delegate (Car c) { return c.Make == "Ford"; });

            Console.WriteLine(fordCar);



            var dodgeCar = cars.Find(c => c.Make == "Dodge");

            Console.WriteLine(dodgeCar);

            Console.ReadKey();

        }

        //Step 1 - Declared method 
        public static bool FindCar(Car car)
        {
            return car.Make == "Tesla";
        }
    }
}
