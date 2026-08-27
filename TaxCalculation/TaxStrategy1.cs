namespace TaxCalculation
{
    public class TaxStrategy1 : ITaxStrategy
    {
        public decimal Calculate(decimal taxableAmount)
        {
            decimal  tax = 0;
            if(taxableAmount > 400000)
            {
                tax += Math.Min(taxableAmount-400000, 400000) * 0.05m;
            }
            if (taxableAmount > 800000)
            {
                tax += Math.Min(taxableAmount - 800000, 400000) * 0.1m;
            }
            if (taxableAmount > 1200000)
            {
                tax += Math.Min(taxableAmount - 1200000, 400000) * 0.15m;
            }
            if (taxableAmount > 1600000)
            {
                tax += Math.Min(taxableAmount - 1600000, 400000) * 0.2m;
            }
            if (taxableAmount > 2000000)
            {
                tax += Math.Min(taxableAmount - 2000000, 400000) * 0.25m;
            }
            if (taxableAmount > 2400000)
            {
                tax += (taxableAmount - 2400000) * 0.3m;
            }
            return tax;
        }
    }
}
