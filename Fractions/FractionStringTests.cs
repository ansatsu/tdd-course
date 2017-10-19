using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions
{
    [TestClass]
    public class FractionStringTests
    {
        [TestMethod]
        public void ToString_formats_numerator_and_denominator_with_forward_slash()
        {
            const int numerator = 15;
            const int denominator = 28;
            Assert.AreEqual($"{numerator}/{denominator}", new Fraction(numerator, denominator).ToString());
        }
    }
}
