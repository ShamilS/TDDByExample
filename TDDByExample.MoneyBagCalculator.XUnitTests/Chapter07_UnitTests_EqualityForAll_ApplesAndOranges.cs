using System;
using Xunit;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    /// <summary>
    /// Done:
    ///  $5*2 = $10
    ///  Make "amount" private
    ///  Dollar side effects?
    ///  Equals
    ///  5 CHF* 2 = 10 CHF
    ///  Common equals
    ///  Francs != Dollars
    /// 
    /// To do:
    ///  $5 + 10 CHF = $10 if CHF:USD is 2:1
    ///  Make “amount” private
    ///  Money rounding?
    ///  HashCode()
    ///  Equal null
    ///  Equal object
    ///  Dollar/Franc duplication
    ///  Common times
    ///  Currency?
    /// </summary>
    public class Chapter07_UnitTests_EqualityForAll_ApplesAndOranges
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
        /// Dollar side effects? => 
        ///    No side effects from previous multiplication =>
        ///    $5 * 3 = 15
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

        /// <summary>
        /// Common equals
        /// </summary>
        [Fact]
        public void TestFact06_TestEquality()
        {
            Assert.True(new Dollar06(5).Equals(new Dollar06(5)));
            Assert.False(new Dollar06(5).Equals(new Dollar06(6)));
            Assert.True(new Franc06(5).Equals(new Franc06(5)));
            Assert.False(new Franc06(5).Equals(new Franc06(6)));
        }


        /// <summary>
        /// Francs not equal Dollars
        /// </summary>
        [Fact]
        public void TestFact07_TestEquality_ApplesAndOranges()
        {
            Assert.False(new Franc06(5).Equals(new Dollar06(5)));
        }
    }
}
