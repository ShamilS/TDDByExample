using System;
using Xunit;
using TDDByExample.MoneyBagCalculator.Chapter03;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter03_UnitTests_EqualityForAll
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestFact01_Multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
        }

        /// <summary>
        /// No side effects from previous multiplication:
        /// $5 * 3 = 15
        /// </summary>
        [Fact]
        public void TestFact02_MultiplicationAndDegenerateObjects()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }

        /// <summary>
        /// Equals()
        /// </summary>
        [Fact]
        public void TestFact_Equals()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
