# Tax Calculation

This project implements tax calculation using the Strategy Design Pattern.

## Tax Strategies

The project has three tax strategies:

- TaxStrategy1 - New Tax Regime, FY 2025-26
- TaxStrategy2 - New Tax Regime, FY 2024-25
- TaxStrategy3 - New Tax Regime, FY 2020-21

All three strategies implement the `ITaxStrategy` interface.

## InvoiceTaxCalculator

`InvoiceTaxCalculator` uses the selected tax strategy to calculate the tax.

The tax strategy can also be changed at runtime using the `Use()` method.

## Testing

Unit tests are written using xUnit.

The tests cover:

- Tax calculation for all three strategies
- Different tax slab values
- Tax slab thresholds
- Replacing one tax strategy with another

## Technologies Used

- C#
- .NET
- xUnit
- Strategy Design Pattern