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
        public void zero_plus_non_zero()
        {
            var fraction = new Fraction(0).Plus(new Fraction(1));
            Assert.AreEqual(1, fraction.IntValue);
        }

        [TestMethod]
        public void non_zero_plus_zero()
        {
            var fraction = new Fraction(2).Plus(new Fraction(0));
            Assert.AreEqual(2, fraction.IntValue);
        }

        [TestMethod]
        public void non_negative_non_zero_operands()
        {
            var fraction = new Fraction(4).Plus(new Fraction(6));
            Assert.AreEqual(10, fraction.IntValue);
        }
    }
}
    