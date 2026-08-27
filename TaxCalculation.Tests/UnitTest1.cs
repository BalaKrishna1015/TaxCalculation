using TaxCalculation;
namespace TaxCalculation.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestStrategy1()
        {
            TaxStrategy1 strategy = new TaxStrategy1();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);

            Assert.Equal(0, calculator.CalculateTax(400000));
            Assert.Equal(5000, calculator.CalculateTax(500000));
            Assert.Equal(20000, calculator.CalculateTax(800000));
            Assert.Equal(60000, calculator.CalculateTax(1200000));
            Assert.Equal(120000, calculator.CalculateTax(1600000));
            Assert.Equal(200000 ,calculator.CalculateTax(2000000));
            Assert.Equal(300000, calculator.CalculateTax(2400000));
        }
        [Fact]
        public void TestStrategy2()
        {
            TaxStrategy2 strategy = new TaxStrategy2();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);
            Assert.Equal(0, calculator.CalculateTax(300000));
            Assert.Equal(5000, calculator.CalculateTax(400000));
            Assert.Equal(20000, calculator.CalculateTax(700000));
            Assert.Equal(50000, calculator.CalculateTax(1000000));
            Assert.Equal(80000, calculator.CalculateTax(1200000));
            Assert.Equal(140000, calculator.CalculateTax(1500000));
            Assert.Equal(170000, calculator.CalculateTax(1600000));
        }
        [Fact]
        public void TestStrategy3()
        {
            TaxStrategy3 strategy = new TaxStrategy3();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);
            Assert.Equal(0, calculator.CalculateTax(250000));
            Assert.Equal(5000, calculator.CalculateTax(350000));
            Assert.Equal(12500, calculator.CalculateTax(500000));
            Assert.Equal(32500, calculator.CalculateTax(600000));
            Assert.Equal(112500, calculator.CalculateTax(1000000));
            Assert.Equal(142500, calculator.CalculateTax(1100000));
            Assert.Equal(442500, calculator.CalculateTax(2100000));
        }
        [Fact]
        public void TestStrategyReplacement2()
        {
            TaxStrategy1 strategy = new TaxStrategy1();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);
            
            decimal result = calculator.CalculateTax(800000);
            calculator.Use(new TaxStrategy2());
            decimal result1 = calculator.CalculateTax(800000);
            Assert.Equal(20000, result);
            Assert.Equal(30000, result1);
        }
        [Fact]
        public void TestStrategyReplacement1()
        {
            TaxStrategy3 strategy = new TaxStrategy3();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);

            decimal result = calculator.CalculateTax(800000);
            calculator.Use(new TaxStrategy1());
            decimal result1 = calculator.CalculateTax(800000);
            Assert.Equal(20000, result1);
            Assert.Equal(72500, result);
        }
        [Fact]
        public void TestStrategyReplacement3()
        {
            TaxStrategy1 strategy = new TaxStrategy1();
            InvoiceTaxCalculator calculator = new InvoiceTaxCalculator(strategy);

            decimal result = calculator.CalculateTax(800000);
            calculator.Use(new TaxStrategy3());
            decimal result1 = calculator.CalculateTax(800000);
            Assert.Equal(20000, result);
            Assert.Equal(72500, result1);
        }

    }
}
