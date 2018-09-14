using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    // it's the same as in Chapter12
    public interface Expression
    {
        Money Reduce(Bank bank, String to);
    }
}
