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
        public Fraction Plus(Fraction that)
        {
            if (this.Denominator != that.Denominator)
                return new Fraction(this.Numerator * that.Denominator + that.Numerator * this.Denominator);
            
            return new Fraction(this.Numerator + that.Numerator, this.Denominator);
        }

        public override bool Equals(object obj)
        {
            return
                obj is Fraction o &&
                o.Numerator == Numerator &&
                o.Denominator == Denominator;
        }

        public override int GetHashCode()
        {
            return (Numerator * 397) ^ Denominator;
        }

        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}