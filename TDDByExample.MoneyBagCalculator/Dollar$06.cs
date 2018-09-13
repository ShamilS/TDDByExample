using System;

namespace TDDByExample.MoneyBagCalculator
{
    /// <summary>
    /// Done:
    ///    Subclassed from Money 
    /// </summary>
    public class Dollar06 : Money
    {
        public Dollar06(int amount) : base(amount) { }
        public Dollar06 Times(int multiplier) => new Dollar06(this.Amount * multiplier);
    }
}
