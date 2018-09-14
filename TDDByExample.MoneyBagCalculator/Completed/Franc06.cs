using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter06
{
    public class Franc:Money
    {
        public Franc(int amount) : base(amount) { }
        public Franc Times(int multiplier) => new Franc(this.Amount * multiplier);
    }
}
