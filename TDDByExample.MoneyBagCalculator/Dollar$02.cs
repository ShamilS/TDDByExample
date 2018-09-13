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
    ///</summary>
    public class Dollar02
    {
        public int Amount { get; private set; }
        public Dollar02(int amount)
        {
            this.Amount = amount;
        }
        public Dollar02 Times(int multiplier)
        {
            return new Dollar02(this.Amount * multiplier);
        }
    }
}
