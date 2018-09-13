using System;

namespace TDDByExample.MoneyBagCalculator
{
    public class Dollar06 : Money
    {
        public Dollar06(int amount) : base(amount) { }
        public Dollar06 Times(int multiplier) => new Dollar06(this.Amount * multiplier);
    }
}
