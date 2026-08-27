using System;

namespace TaxCalculation
{
    public interface ITaxStrategy
    {
        decimal Calculate(decimal taxableAmount);
    }
}
