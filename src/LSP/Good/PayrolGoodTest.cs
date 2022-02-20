using Xunit;

namespace LSP.Good
{
    public class PayrolGoodTest
    {
        [Fact]
        public void ShouldCalculateTotalValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new CLT("Joao", 1000));
            payRoll.AddEmployee(new PJ("Maria", 2000));
            payRoll.AddEmployee(new MEI("Jose", 2000));

            Assert.Equal(5300, payRoll.GetTotalValue());
        }

        [Fact]
        public void ShouldCalculateNetValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new CLT("Joao", 1000));
            payRoll.AddEmployee(new PJ("Maria", 2000));
            payRoll.AddEmployee(new MEI("Jose", 2000));

            Assert.Equal(4500, payRoll.GetNetValue());
        }

        [Fact]
        public void ShouldCalculateTaxesValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new CLT("Joao", 1000));
            payRoll.AddEmployee(new PJ("Maria", 2000));
            payRoll.AddEmployee(new MEI("Jose", 2000));

            Assert.Equal(800, payRoll.GetTaxes());
        }
    }
}
