/*
 * Copyright 2016-2020 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: Jamie Forde
 * Date: 2020-06-12
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabExercise03_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = Read(@"..\..\Cars.csv");

            int userChoice = 0;

            // Main loop
            while (userChoice != 4)
            {
                Console.Clear();
                DisplayMenu();

                var validChoice = int.TryParse(Console.ReadLine(), out userChoice);

                if (validChoice)
                {
                    ResolveUserChoice(userChoice, cars);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Choice -- Try Again");
                }
            }
        }

        /// <summary>
        /// Method displays options to user
        /// </summary>
        public static void DisplayMenu()
        {
            Console.WriteLine("CAR APPLICATION");
            Console.WriteLine(new string('=', 15));
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Display all of the Cars");
            Console.WriteLine("2 - List car with best Mileage");
            Console.WriteLine("3 - List all cars from Ford");
            Console.WriteLine("4 - Exit Application");
            Console.WriteLine("\nEnter Option:");
        }

        /// <summary>
        /// Displays all the cars
        /// </summary>
        /// <param name="cars"></param>
        public static void DisplayAllCars(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        /// <summary>
        /// Displays car with best fuel efficiency
        /// </summary>
        /// <param name="cars">A collection of cars</param>
        public static void DisplayCarBestMileage(Car[] cars)
        {

            double bestFuelEfficiency = cars[0].CalculateFuelEfficiency();
            Car carWithBestFuelefficiency = cars[0];

            foreach (var car in cars)
            {
                var fuelEfficiency = car.CalculateFuelEfficiency();

                if (fuelEfficiency.CompareTo(bestFuelEfficiency) < 0)
                {
                    bestFuelEfficiency = fuelEfficiency;
                    carWithBestFuelefficiency = car;
                }
            }

            Console.WriteLine("The car with the best fuel efficiency:");
            Console.WriteLine($"\t{carWithBestFuelefficiency}");
        }

        /// <summary>
        /// Method to display all cars with a Ford make.
        /// </summary>
        /// <param name="cars">An array of cars</param>
        public static void DisplayFordCars(Car[] cars)
        {
            foreach (var car in cars)
            {
                if (car.GetMake().ToLower() == "ford")
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        /// <summary>
        /// Resolves the user's selection.
        /// </summary>
        /// <param name="userChoice">Represents the choice made by the user</param>
        /// <param name="cars">Represents a collection of type Car <see cref="Car"/></param>
        public static void ResolveUserChoice(int userChoice, Car[] cars)
        {
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    DisplayAllCars(cars);
                    break;
                case 2:
                    DisplayCarBestMileage(cars);
                    break;
                case 3:
                    DisplayFordCars(cars);
                    break;
                case 4:
                    Console.WriteLine("Program Terminated");
                    break;
                default:
                    Console.WriteLine("Invalid Choice -- Try Again");
                    break;
            }
        }

        /// <summary>
        /// Method to read a file of cars.
        /// </summary>
        /// <param name="fileName">Represents a file that contains a data file of cars</param>
        /// <returns></returns>
        public static Car[] Read(string fileName)
        {
            Car[] cars = new Car[6];
            try
            {
                StreamReader reader = new StreamReader(fileName);
                int counter = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] split = line.Split(',');

                    for (var i = 0; i < split.Length - 1; i++)
                    {
                        Car newCar = new Car(split[0], split[1], int.Parse(split[2]), int.Parse(split[3]));
                        cars[counter] = newCar;
                    }
                    counter++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not read in file!");
            }

            return cars;
        }
    }
}
