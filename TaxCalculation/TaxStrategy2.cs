using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculation
{
    public class TaxStrategy2 : ITaxStrategy
    {
        public decimal Calculate(decimal taxableAmount)
        {
            decimal tax = 0;
            if (taxableAmount > 300000)
            {
                tax += Math.Min(taxableAmount - 300000, 400000) * 0.05m;
            }
            if (taxableAmount > 700000)
            {
                tax += Math.Min(taxableAmount - 700000, 300000) * 0.1m;
            }
            if (taxableAmount > 1000000)
            {
                tax += Math.Min(taxableAmount - 1000000, 200000) * 0.15m;
            }
            if (taxableAmount > 1200000)
            {
                tax += Math.Min(taxableAmount - 1200000, 300000) * 0.2m;
            }
            if (taxableAmount > 1500000)
            {
                tax += (taxableAmount - 1500000) * 0.3m;
            }
            return tax;
        }
    }
}
