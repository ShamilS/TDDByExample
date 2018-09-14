using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    public class Sum:Expression
    {
        private Money augend;
        private Money addend;
        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }
        public Money Reduce(Bank bank, String to)
        {
            int amount = augend.Amount + addend.Amount;
            return new Money(amount, to);
        }
    }
}
