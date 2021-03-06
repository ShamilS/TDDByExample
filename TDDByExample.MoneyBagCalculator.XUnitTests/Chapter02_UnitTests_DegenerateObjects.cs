using System;
using Xunit;
using TDDByExample.MoneyBagCalculator.Chapter02;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter02_UnitTests_DegenerateObjects
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestMultiplication_Fact01()
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
        public void TestMultiplication_Fact()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }
    }
}
