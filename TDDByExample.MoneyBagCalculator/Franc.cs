using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator
{
    /// <summary>
    /// Done: 
    ///   +05.
    ///     5 CHF * 2 = 10 CHF 
    /// </summary>
    public class Franc
    {
        private int Amount { get; set; }
        public Franc(int amount)
        {
            this.Amount = amount;
        }
        public Franc Times(int multiplier) => new Franc(this.Amount * multiplier);
        public override bool Equals(object obj) => ((Franc)obj).Amount == this.Amount;
    }
}
