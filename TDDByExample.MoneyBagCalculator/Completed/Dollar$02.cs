using System;

namespace TDDByExample.MoneyBagCalculator.Chapter02
{
    ///<summary>
    /// Done: 
    ///   + 01. Multi-Currency Money
    ///     * No class “Dollar”
    ///     * No constructor
    ///     * No method “times(int)”
    ///     * No field “amount”
    ///     $5 * 2 = $10
    ///   +. Degenerate Objects
    ///     Dollar side-effects?
    ///</summary>
    public class Dollar
    {
        public int Amount { get; private set; }
        public Dollar(int amount)
        {
            this.Amount = amount;
        }
        public Dollar Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }
    }
}
