using System;
using Xunit;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter05_UnitTests_Franc_lySpeaking
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestFact01_Multiplication()
        {
            Dollar04 five = new Dollar04(5);
            Dollar04 product = five.Times(2);
            Assert.Equal(new Dollar04(10), product);
        }

        /// <summary>
        /// No side effects from previous multiplication:
        /// $5 * 3 = 15
        /// </summary>
        [Fact]
        public void TestFact02_MultiplicationAndDegenerateObjects()
        {
            Dollar04 five = new Dollar04(5);
            Dollar04 product = five.Times(2);
            Assert.Equal(new Dollar04(10), product);
            product = five.Times(3);
            Assert.Equal(new Dollar04(15), product);
        }

        /// <summary>
        /// Equals()
        /// </summary>
        [Fact]
        public void TestFact03_Equals()
        {
            Assert.True(new Dollar04(5).Equals(new Dollar04(5)));
            Assert.False(new Dollar04(5).Equals(new Dollar04(6)));
        }

        /// <summary>
        /// Make “amount” private
        /// </summary>
        [Fact]
        public void TestFact04_MakeAmountPrivate ()
        {
            Assert.Equal(new Dollar04(10), new Dollar04(5).Times(2));
            Assert.Equal(new Dollar04(15), new Dollar04(5).Times(3));
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
    }
}
