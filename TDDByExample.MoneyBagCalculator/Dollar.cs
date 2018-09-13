using System;

namespace TDDByExample.MoneyBagCalculator
{
    public class Dollar
    {
        public int Amount { get; private set; }
        public Dollar(int amount)
        {
            this.Amount = amount;
        }
        public void Times(int multiplier)
        {
            this.Amount *= multiplier;
        }
    }
}
