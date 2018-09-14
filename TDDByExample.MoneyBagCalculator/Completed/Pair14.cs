using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    internal class Pair
    {
        private String from;
        private String to;
        internal Pair(String from, String to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(Object obj)
        {
            Pair pair = (Pair)obj;
            return from.Equals(pair.from) & to.Equals(pair.to);
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
