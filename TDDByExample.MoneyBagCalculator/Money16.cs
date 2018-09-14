using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter16
{
    // it's the same as in Chapter11 and Chapter12
    public class Money:IExpression
    {
        public int Amount { get; private set; }
        public string Currency { get; private set; }
        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public IExpression Times(int multiplier)=> new Money(this.Amount * multiplier, this.Currency);
        public IExpression Plus(IExpression addend) => new Sum(this, addend);
        public Money Reduce(Bank bank, String to) => new Money(this.Amount / bank.Rate(this.Currency, to), to);
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount && this.Currency.Equals(((Money)obj).Currency);

        public static Money Dollar(int amount) => new Dollar(amount, "USD");
        public static Money Franc(int amount) => new Franc(amount, "CHF");
    }
}
