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
    ///</summary>
    public class Dollar03
    {
        public int Amount { get; private set; }
        public Dollar03(int amount)
        {
            this.Amount = amount;
        }
        public Dollar03 Times(int multiplier) => new Dollar03(this.Amount * multiplier);
        public override bool Equals(object obj) => ((Dollar03)obj).Amount == this.Amount;
    }
}
