using System;

namespace Fractions
{
    public class Fraction
    {
        public int IntValue { get; }

        public Fraction(int value)
        {
            IntValue = value;
        }

        public override bool Equals(object obj)
        {
            var o = obj as Fraction;
            return o != null && o.IntValue == this.IntValue;
        }

        public Fraction Plus(Fraction fraction) => new Fraction(IntValue + fraction.IntValue);
    }
}