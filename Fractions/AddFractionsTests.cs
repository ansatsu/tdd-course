using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions
{
    [TestClass]
    public class AddFractionsTests
    {
        [TestMethod]
        public void zero_plus_zero()
        {
            var fraction = new Fraction(0).Plus(new Fraction(0));
            Assert.AreEqual(0, fraction.IntValue);
        }

        [TestMethod]
        public void zero_plus_nonzero()
        {
            var fraction = new Fraction(0).Plus(new Fraction(1));
            Assert.AreEqual(1, fraction.IntValue);
        }

        [TestMethod]
        public void nonzero_plus_zero()
        {
            var fraction = new Fraction(2).Plus(new Fraction(0));
            Assert.AreEqual(2, fraction.IntValue);
        }
    }
}