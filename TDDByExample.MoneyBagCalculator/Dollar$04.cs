using System;

namespace TDDByExample.MoneyBagCalculator.Chapter04
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
    ///   +.
    ///     Make “amount” private
    ///</summary>
    public class Dollar
    {
        private int Amount { get; set; }
        public Dollar(int amount)
        {
            this.Amount = amount;
        }
        public Dollar Times(int multiplier) => new Dollar(this.Amount * multiplier);
        public override bool Equals(object obj) => ((Dollar)obj).Amount == this.Amount;
    }
}
