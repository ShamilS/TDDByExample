using System;
using Xunit;

using TDDByExample.MoneyBagCalculator.Chapter06;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter06_UnitTests_EqualityForAll_Redux
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestFact01_Multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(new Dollar(10), product);
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
            Assert.Equal(new Dollar(10), product);
            product = five.Times(3);
            Assert.Equal(new Dollar(15), product);
        }

        /// <summary>
        /// Equals()
        /// </summary>
        [Fact]
        public void TestFact03_Equals()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }

        /// <summary>
        /// Make �amount� private
        /// </summary>
        [Fact]
        public void TestFact04_MakeAmountPrivate ()
        {
            Assert.Equal(new Dollar(10), new Dollar(5).Times(2));
            Assert.Equal(new Dollar(15), new Dollar(5).Times(3));
        }

        /// <summary>
        /// 5 CHF * 2 = 10 CHF
        /// </summary>
        [Fact]
        public void TestFact05_Franc_lySpeaking()
        {
            Assert.Equal(new Franc(10), new Franc(5).Times(2));
            Assert.Equal(new Franc(15), new Franc(5).Times(3));
        }

        /// <summary>
        /// Common equals
        /// </summary>
        [Fact]
        public void TestFact_TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
        }

        /// <summary>
        /// Francs not equal Dollars
        /// </summary>

    }
}
