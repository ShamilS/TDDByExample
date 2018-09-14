using System;
using Xunit;
using TDDByExample.MoneyBagCalculator.Chapter01;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter01_UnitTests_MultiCurrencyMoney
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestMultiplication_Fact01()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
