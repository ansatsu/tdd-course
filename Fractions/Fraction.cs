namespace Fractions
{
    internal class Fraction
    {
        private int v;

        public Fraction(int v)
        {
            this.v = v;
        }

        public override bool Equals(object obj)
        {
            var o = obj as Fraction;
            return o != null && o.v == this.v;
        }
    }
}