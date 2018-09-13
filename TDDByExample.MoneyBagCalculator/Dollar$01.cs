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
    /// </summary>
    public class Dollar01
    {
        public int Amount { get; private set; }
        public Dollar01(int amount)
        {
            this.Amount = amount;
        }
        public void Times(int multiplier)
        {
            this.Amount *= multiplier;
        }
    }
}
