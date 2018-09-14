using System;

namespace TDDByExample.MoneyBagCalculator.Chapter06
{
    public class Dollar : Money
    {
        public Dollar(int amount) : base(amount) { }
        public Dollar Times(int multiplier) => new Dollar(this.Amount * multiplier);
    }
}
