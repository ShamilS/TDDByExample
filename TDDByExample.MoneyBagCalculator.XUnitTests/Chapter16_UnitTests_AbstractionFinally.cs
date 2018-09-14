using System;
using Xunit;
using TDDByExample.MoneyBagCalculator.Chapter16;

namespace TDDByExample.MoneyBagCalculator.XUnitTests
{
    /// <summary>
    /// 
    /// Done:
    /// 
    ///  $5*2 = $10
    ///  Make "amount" private
    ///  Dollar side effects?
    ///  Equals
    ///  5 CHF* 2 = 10 CHF
    ///  Common equals
    ///  Francs != Dollars
    ///  Currency?
    ///  Dollar/Franc duplication
    ///  Common times
    ///  Delete testFrancMultiplication?
    ///  $5 + $5 = $10
    ///  Bank.Reduce(Money)
    ///  Reduce Money with conversion
    ///  $5 + 10 CHF = $10 if CHF:USD is 2:1
    ///  Return Money from $5 + $5
    ///  Money rounding?
    ///  Reduce(Bank, String) vs Reduce(String)  - ignored = we have to ship now!
    ///  Expression.Plus
    ///  Sum.Plus
    ///  Expression.Times
    ///  
    ///  HashCode()
    ///  Equal null
    ///  Equal object
    ///  
    /// To do:
    /// 
    /// </summary>
    public class Chapter16_UnitTests_AbstractionFinally
    {
        /// <summary>
        /// $5 * 2 = $10
        /// </summary>
        [Fact]
        public void TestFact01_Multiplication()
        {
            Money five = Money.Dollar(5);
            IExpression product = five.Times(2);
            Assert.Equal(Money.Dollar(10), product);
        }

        /// <summary>
        /// Dollar side effects? => 
        ///    No side effects from previous multiplication =>
        ///    $5 * 3 = 15
        /// </summary>
        [Fact]
        public void TestFact02_MultiplicationAndDegenerateObjects()
        {
            Money five = Money.Dollar(5);
            IExpression product = five.Times(2);
            Assert.Equal(Money.Dollar(10), product);
            product = five.Times(3);
            Assert.Equal(Money.Dollar(15), product);
            // chapter08
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        /// <summary>
        /// Equals()
        /// </summary>
        [Fact]
        public void TestFact03_Equals()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
        }

        /// <summary>
        /// Make �amount� private
        /// </summary>
        [Fact]
        public void TestFact04_MakeAmountPrivate ()
        {
            Assert.Equal(Money.Dollar(10), Money.Dollar(5).Times(2));
            Assert.Equal(Money.Dollar(15), Money.Dollar(5).Times(3));
        }

        /// <summary>
        /// 5 CHF * 2 = 10 CHF
        /// </summary>
        [Fact]
        public void TestFact05_Franc_lySpeaking()
        {
            Assert.Equal(Money.Franc(10), Money.Franc(5).Times(2));
            Assert.Equal(Money.Franc(15), Money.Franc(5).Times(3));
        }

        /// <summary>
        /// Common equals
        /// </summary>
        [Fact]
        public void TestFact06_TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
        }


        /// <summary>
        /// Francs not equal Dollars
        /// </summary>
        [Fact]
        public void TestFact07_TestEquality_ApplesAndOranges()
        {
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));;
        }

        /// <summary>
        /// Currency
        /// </summary>
        [Fact]
        public void TestFact08_Currency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency);
            Assert.Equal("CHF", Money.Franc(1).Currency);
        }

        /// <summary>
        /// $5 + $5 = $10
        ///  Return Money from $5 + $5
        ///  Reduce(Bank, String) vs Reduce(String)
        /// </summary>
        [Fact]
        public void TestFact08_SimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10), reduced);
        }

        /// <summary>
        /// Bank.reduce(Money)
        /// </summary>
        [Fact]
        public void TestFact09_ReduceSum()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

        /// <summary>
        /// Test identity rate
        /// </summary>
        [Fact]
        public void TestFact10_IdentityRate()
        {
            Assert.Equal(1, new Bank().Rate("USD", "USD"));
        }

        /// <summary>
        /// Reduce Money with conversion
        /// </summary>
        [Fact]
        public void TestFact11_ReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        /// <summary>
        /// $5 + 10 CHF = $10 if CHF:USD is 2:1
        /// </summary>
        [Fact]
        public void TestFact12_MixedAddition()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }

        [Fact]
        public void TestFact13_SumPlusMoney()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);

            IExpression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(15), result);
        }

        [Fact]
        public void TestFact14_PlusSameCurrencyReturnsMoney()
        {
            IExpression sum = Money.Dollar(1).Plus(Money.Dollar(1));

            // sum has to be reduced to money!
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money money = sum.Reduce(bank, "USD");

            Assert.True(money is Money);
        }
    }
}
