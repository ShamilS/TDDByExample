using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter13
{
    // it's the same as in Chapter12
    public interface Expression
    {
        Money Reduce(String to);
    }
}
