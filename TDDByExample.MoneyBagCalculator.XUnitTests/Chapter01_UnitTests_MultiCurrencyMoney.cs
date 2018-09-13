using System;
using Xunit;

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
            Dollar01 five = new Dollar01(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
