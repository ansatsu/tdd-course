using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions
{
    [TestClass]
    public class FractionEqualsTests
    {
        [TestMethod]
        public void same_numerator_and_denominator()
        {
            Assert.AreEqual(new Fraction(3, 4), new Fraction(3, 4));
        }

        [TestMethod]
        public void different_numerators()
        {
            Assert.AreNotEqual(new Fraction(2, 3), new Fraction(5, 3));
        }

        [TestMethod]
        public void different_denominators()
        {
            Assert.AreNotEqual(new Fraction(4, 5), new Fraction(4, 8));
        }

        [TestMethod]
        public void whole_numbers_equals_the_same_fraction()
        {
            Assert.AreEqual(new Fraction(3, 1), new Fraction(3));
        }

        [TestMethod]
        public void different_whole_numbers_do_not_equal_each_other()
        {
            Assert.AreNotEqual(new Fraction(2), new Fraction(3));
        }

        //[TestMethod]
        //public void reduces()
        //{
        //    Assert.AreEqual(new Fraction(2, 3), new Fraction(4, 6));
        //}
    }
}
