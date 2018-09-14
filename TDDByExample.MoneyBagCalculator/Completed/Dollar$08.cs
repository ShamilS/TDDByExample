using System;

namespace TDDByExample.MoneyBagCalculator.Chapter08
{
    public class Dollar : Money
    {
        public Dollar(int amount) : base(amount) { }
        public override Money Times(int multiplier) => new Dollar(this.Amount * multiplier);
    }
}
