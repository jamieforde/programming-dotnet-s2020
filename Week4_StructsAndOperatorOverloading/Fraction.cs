using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Creating Value Types - Struct
 * C#'s simple types (int, double) are aliases for struct
 * Use a struct vs a class if instances of types:
    * Represents a single value
    * Are small - no more than 16 bytes
    * Immutable
    * It will not have to be boxed (casting to reference type) frequently 
 * Limitations:
    * Cannot declare a parameterless constructor.
    * Cannot initialize an instance field or property at declaration.  
        *  However can initialize a static or const field or a static property.
    * Constructor must initialize all instances fields
    * Structure cannot inherit from other types and it cannot be a base class.
    * Can implement interfaces.
*/

namespace Week4_StructsAndOperatorOverloading
{
    // 
    public readonly struct Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero", nameof(denominator));
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new Fraction(-a.numerator, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);


        

        public override string ToString() => $"{numerator}/{denominator}";

    }
}
