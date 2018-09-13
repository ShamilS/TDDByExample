using System;
using Xunit;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    public class Chapter04_UnitTests_Privacy
    {
        #region This test doesn't compile now as Amount property was made private => use TestFact04_MakeAmountPrivate instead
        ///// <summary>
        ///// $5 * 2 = $10
        ///// </summary>
        //[Fact]
        //public void TestFact01_Multiplication()
        //{
        //    Dollar04 five = new Dollar04(5);
        //    Dollar04 product = five.Times(2);
        //    Assert.Equal(10, product.Amount);
        //}
        #endregion

        #region This test doesn't compile now as Amount property was made private => use TestFact04_MakeAmountPrivate instead
        ///// <summary>
        ///// No side effects from previous multiplication:
        ///// $5 * 3 = 15
        ///// </summary>
        //[Fact]
        //public void TestFact02_MultiplicationAndDegenerateObjects()
        //{
        //    Dollar04 five = new Dollar04(5);
        //    Dollar04 product = five.Times(2);
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
            Assert.True(new Dollar04(5).Equals(new Dollar04(5)));
            Assert.False(new Dollar04(5).Equals(new Dollar04(6)));
        }

        /// <summary>
        /// $5 * 2 = $10
        /// No side effects from previous multiplication:
        /// $5 * 3 = 15
        /// Make “amount” private
        /// </summary>
        [Fact]
        public void TestFact04_MakeAmountPrivate ()
        {
            Assert.Equal(new Dollar04(10), new Dollar04(5).Times(2));
            Assert.Equal(new Dollar04(15), new Dollar04(5).Times(3));
        }
    }
}
