using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter12
{
    public class Money:Expression
    {
        protected int Amount { get; set; }
        public string Currency { get; private set; }
        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public Money Times(int multiplier) => new Money(this.Amount * multiplier, this.Currency);
        public Money Plus(Money addend) => new Money(this.Amount + addend.Amount, this.Currency);
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount && this.Currency.Equals(((Money)obj).Currency);

        public static Money Dollar(int amount) => new Dollar(amount, "USD");
        public static Money Franc(int amount) => new Franc(amount, "CHF");
    }
}
