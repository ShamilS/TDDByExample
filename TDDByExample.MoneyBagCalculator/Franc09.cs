using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter09
{
    public class Franc:Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }
        public override Money Times(int multiplier) => Money.Franc(this.Amount * multiplier);
    }
}
