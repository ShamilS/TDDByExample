﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.MoneyBagCalculator.Chapter14
{
    // it's the same as in Chapter11 and Chapter12
    public class Money:Expression
    {
        public int Amount { get; private set; }
        public string Currency { get; private set; }
        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public Money Times(int multiplier) => new Money(this.Amount * multiplier, this.Currency);
        public Money Plus(Money addend) => new Money(this.Amount + addend.Amount, this.Currency);
        public override bool Equals(object obj) => ((Money)obj).Amount == this.Amount && this.Currency.Equals(((Money)obj).Currency);

        public Money Reduce(Bank bank, String to)
        {
            int rate = bank.Rate(this.Currency, to);
            return new Money(this.Amount / rate, to);
        }

        public static Money Dollar(int amount) => new Dollar(amount, "USD");
        public static Money Franc(int amount) => new Franc(amount, "CHF");
    }
}
