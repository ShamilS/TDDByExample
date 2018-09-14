using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter12
{
    // it's the same as in Chapter11
    public class Franc:Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }
    }
}
