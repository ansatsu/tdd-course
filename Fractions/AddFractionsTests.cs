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
    }
}
