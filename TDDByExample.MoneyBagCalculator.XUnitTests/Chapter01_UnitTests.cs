using System;
using Xunit;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter01_UnitTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
