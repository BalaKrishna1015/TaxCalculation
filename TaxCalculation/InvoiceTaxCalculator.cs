using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculation
{
    public sealed class InvoiceTaxCalculator(ITaxStrategy strategy)
    {
        //private ITaxStrategy strategy;
        
        public void Use(ITaxStrategy replacement)
        {
            strategy = replacement;
        }

        public decimal CalculateTax(decimal amount)
        {
            return strategy.Calculate(amount);
        }
    }
}
