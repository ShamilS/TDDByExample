using System;
using System.Collections.Generic;
using System.Text;
using TDDByExample.MoneyBagCalculator.Chapter12;

namespace TDDByExample.MoneyBagCalculator.Chapter13
{
    public class Bank
    {
        public Money Reduce(Expression source, String to)
        {
            if (source is Money) return (Money)source;
            Sum sum = (Sum)source;
            return sum.Reduce(to);
        }
    }
}
