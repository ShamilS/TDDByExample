using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter16
{
    // it's the same as in Chapter12
    public interface IExpression
    {
        Money Reduce(Bank bank, String to);
        IExpression Plus(IExpression addend);
        IExpression Times(int multiplier);
    }
}
