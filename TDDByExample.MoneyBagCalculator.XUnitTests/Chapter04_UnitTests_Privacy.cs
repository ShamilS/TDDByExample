using System;
using Xunit;
using TDDByExample.MoneyBagCalculator.Chapter04;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter04_UnitTests_Privacy
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

        #region This test doesn't compile now as Amount property was made private => use TestFact_MakeAmountPrivate instead
        ///// <summary>
        ///// No side effects from previous multiplication:
        ///// $5 * 3 = 15
        ///// </summary>
        //[Fact]
        //public void TestFact02_MultiplicationAndDegenerateObjects()
        //{
        //    Dollar five = new Dollar(5);
        //    Dollar product = five.Times(2);
        //    Assert.Equal(10, product.Amount);
        //    product = five.Times(3);
        //    Assert.Equal(15, product.Amount);
        //}
        #endregion

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
        /// $5 * 2 = $10
        /// No side effects from previous multiplication:
        /// $5 * 3 = 15
        /// Make “amount” private
        /// </summary>
        [Fact]
        public void TestFact_MakeAmountPrivate ()
        {
            Assert.Equal(new Dollar(10), new Dollar(5).Times(2));
            Assert.Equal(new Dollar(15), new Dollar(5).Times(3));
        }
    }
}
