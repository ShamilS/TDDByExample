using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    // it's the same as in Chapter11 and Chapter12
    public class Franc:Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }
    }
}
