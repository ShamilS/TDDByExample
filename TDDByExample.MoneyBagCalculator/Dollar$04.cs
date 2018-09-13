using System;

namespace TDDByExample.MoneyBagCalculator
{
    ///<summary>
    /// Done: 
    ///   + 01. Multi-Currency Money
    ///     * No class “Dollar”
    ///     * No constructor
    ///     * No method “times(int)”
    ///     * No field “amount”
    ///     $5 * 2 = $10
    ///   +02. Degenerate Objects
    ///     Dollar side-effects?
    ///   +03.
    ///     Equals()
    ///   +04.
    ///     Make “amount” private
    ///</summary>
    public class Dollar04
    {
        private int Amount { get; set; }
        public Dollar04(int amount)
        {
            this.Amount = amount;
        }
        public Dollar04 Times(int multiplier) => new Dollar04(this.Amount * multiplier);
        public override bool Equals(object obj) => ((Dollar04)obj).Amount == this.Amount;
    }
}
