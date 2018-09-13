using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator
{
    public class Franc06:Money
    {
        public Franc06(int amount) : base(amount) { }
        public Franc06 Times(int multiplier) => new Franc06(this.Amount * multiplier);
    }
}
