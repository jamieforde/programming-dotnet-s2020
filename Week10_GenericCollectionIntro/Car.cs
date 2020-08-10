using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Week10_GenericCollectionIntro.CarComparer;

namespace Week10_GenericCollectionIntro
{
    public class Car : IComparable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Make: {Make,-10} Model: {Model,-10} Year: {Year,-4}";
        }

        public int CompareTo(Car car)
        {
            return this.Year.CompareTo(car.Year);
        }

        public static CarComparer GetComparer()
        {
            return new CarComparer();
        }


        public int CompareTo(Car rhs, ComparisonType which)
        {
            switch(which)
            {
                case ComparisonType.Make:
                    return this.Make.CompareTo(rhs.Make);
                case ComparisonType.Year:
                    return this.Year.CompareTo(rhs.Year);
            }
            return 0;
        }
    }
}
