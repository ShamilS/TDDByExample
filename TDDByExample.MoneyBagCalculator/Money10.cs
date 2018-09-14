using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter10
{
    public class Money
    {
        public Money Times(int multiplier) => new Money(this.Amount * multiplier, this.Currency);
        public string Currency { get; private set; }

        protected int Amount { get; set; }
        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount && this.Currency.Equals(((Money)obj).Currency);
        public static Money Dollar(int amount) => new Dollar(amount, "USD");
        public static Money Franc(int amount) => new Franc(amount, "CHF");
    }
}
