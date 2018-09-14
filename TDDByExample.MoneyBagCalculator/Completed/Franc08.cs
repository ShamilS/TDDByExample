using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter08
{
    public class Franc:Money
    {
        public Franc(int amount) : base(amount) { }
        public override Money Times(int multiplier) => new Franc(this.Amount * multiplier);
    }
}
