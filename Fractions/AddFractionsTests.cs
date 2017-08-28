using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions
{
    [TestClass]
    public class AddFractionsTests
    {
        [TestMethod]
        public void zero_plus_zero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0));
        }
    }
}
