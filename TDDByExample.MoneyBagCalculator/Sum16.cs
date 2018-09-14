using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter16
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
        public Money Reduce(Bank bank, String to) => new Money(augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount, to);
        public IExpression Plus(IExpression addend) => new Sum(this, addend);
        public IExpression Times(int multiplier) => new Sum(augend.Times(multiplier), addend.Times(multiplier));
    }
}
