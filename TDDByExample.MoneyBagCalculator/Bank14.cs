using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();
        public void AddRate(String from, String to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int rate(String from, String to)
        {
            if (from.Equals(to)) return 1;
            int rate = (int)rates[new Pair(from, to)];
            return rate;
        }

        public Money Reduce(Expression source, String to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(String from, String to)
        {
            return (from.Equals("CHF") & to.Equals("USD"))
            ? 2
            : 1;
        }
    }
}
