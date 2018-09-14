using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter16
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();
        public void AddRate(String from, String to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(String from, String to)
        {
            if (from.Equals(to)) return 1;
            int rate = (int)rates[new Pair(from, to)];
            return rate;
        }

        public Money Reduce(IExpression source, String to) => source.Reduce(this, to);
    }
}
