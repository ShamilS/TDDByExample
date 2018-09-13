using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator
{
    /// <summary>
    /// Done:
    ///    Generic Money (this) class created
    /// </summary>
    public class Money
    {
        protected int Amount { get; set; }
        public Money(int amount)
        {
            this.Amount = amount;
        }
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount;
    }
}
