using System;

namespace TDDByExample.MoneyBagCalculator.Chapter09
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency) { }
        public override Money Times(int multiplier) => Money.Dollar(this.Amount * multiplier);
    }
}
