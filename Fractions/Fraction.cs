namespace Fractions
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator)
            : this(numerator, 1)
        { }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction Plus(Fraction fraction) => new Fraction(Numerator + fraction.Numerator, Denominator);

        public override bool Equals(object obj)
        {
            return
                obj is Fraction o &&
                o.Numerator == this.Numerator &&
                o.Denominator == this.Denominator;
        }

        public override int GetHashCode()
        {
            return (Numerator * 397) ^ Denominator;
        }
    }
}