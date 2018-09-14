using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter08
{
    public abstract class Money
    {
        public abstract Money Times(int multiplier);

        protected int Amount { get; set; }
        public Money(int amount)
        {
            this.Amount = amount;
        }
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount && obj.GetType().Equals(this.GetType());

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
