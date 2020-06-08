using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise2_Part1
{
    public class Car
    {
        public Car(string make, string model, double fuel, double mileage)
        {
            Make = make;
            Model = model;
            Fuel = fuel;
            Mileage = mileage;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Mileage { get; set; }
        public double Efficiency => Fuel / Mileage * 100;
    }
}
