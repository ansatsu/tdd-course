using System;

namespace Fractions
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override bool Equals(object obj)
        {
            var o = obj as Fraction;
            return o != null && o.Numerator == this.Numerator;
        }

        public Fraction Plus(Fraction fraction) => new Fraction(Numerator + fraction.Numerator, Denominator);
    }
}