using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculation
{
    public class TaxStrategy3 : ITaxStrategy
    {
        public decimal Calculate(decimal taxableAmount)
        {
            decimal tax = 0;
            if (taxableAmount > 250000)
            {
                tax += Math.Min(taxableAmount - 250000, 250000) * 0.05m;
            }
            if (taxableAmount > 500000)
            {
                tax += Math.Min(taxableAmount - 500000, 500000) * 0.2m;
            }
            if (taxableAmount > 1000000)
            {
                tax += (taxableAmount - 1000000) * 0.3m;
            }
            return tax;
        }
    }
}
