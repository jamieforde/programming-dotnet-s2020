using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_GenericCollectionIntro
{
    public class CarComparer : IComparer<Car>
    {
        public ComparisonType WhichComparison { get; set; }


        public enum ComparisonType
        {
            Make,
            Year
        }

        public int Compare(Car lhs, Car rhs)
        {
            return lhs.CompareTo(rhs, WhichComparison);
        }
    }
}
