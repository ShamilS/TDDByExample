using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter11
{
    public class Franc:Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }
    }
}
