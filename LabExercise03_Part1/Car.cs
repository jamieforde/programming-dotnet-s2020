using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise03_Part1
{
    /// <summary>
    /// Represents a car
    /// </summary>
    public class Car
    {
        private string make;
        private string model;
        private double fuel;
        private double mileage;

        /// <summary>
        /// Constuctor for a Car
        /// </summary>
        /// <param name="make">Represents the manufacture who makes the car</param>
        /// <param name="model">Represents the manufacture model of the car</param>
        /// <param name="fuel">Represent fuel consumed in litres</param>
        /// <param name="mileage">Represents mileage achieved</param>
        public Car(string make, string model, double fuel, double mileage)
        {
            this.make = make;
            this.model = model;
            this.fuel = fuel;
            this.mileage = mileage;
        }

        /// <summary>
        /// Calculates the fuel efficiency of a car
        /// </summary>
        /// <returns></returns>
        public double CalculateFuelEfficiency()
        {
            return fuel / mileage * 100;
        }

        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model;
        }

        /// <summary>
        /// String representation of a car
        /// </summary>
        /// <returns>A formatted string for a car</returns>
        public override string ToString() => $"{make},{model} Used={fuel} Mileage={mileage} " +
            $"Fuel Efficiency={CalculateFuelEfficiency():F2}";  
        


    }
}
