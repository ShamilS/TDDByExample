using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter15
{
    public class Sum:IExpression
    {
        private IExpression augend;
        private IExpression addend;
        public Sum(IExpression augend, IExpression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }
        public Money Reduce(Bank bank, String to)
        {
            int amount = augend.Reduce(bank, to).Amount + addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }
        public IExpression Plus(IExpression addend)
        {
            return null;
        }
    }
}
