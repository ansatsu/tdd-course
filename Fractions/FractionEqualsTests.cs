using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
