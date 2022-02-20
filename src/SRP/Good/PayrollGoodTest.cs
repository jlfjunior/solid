using Xunit;

namespace SRP.Good
{
    public class PayrollGoodTest
    {
        [Fact]
        public void ShouldCalculateTotalValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("CLT", 1000));
            payRoll.AddEmployee(new Employee("PJ", 2000));
            payRoll.AddEmployee(new Employee("MEI", 2000));

            Assert.Equal(5300, payRoll.GetTotalValue());
        }

        [Fact]
        public void ShouldCalculateNetValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("CLT", 1000));
            payRoll.AddEmployee(new Employee("PJ", 2000));
            payRoll.AddEmployee(new Employee("MEI", 2000));

            Assert.Equal(4500, payRoll.GetNetValue());
        }

        [Fact]
        public void ShouldCalculateTaxesValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("CLT", 1000));
            payRoll.AddEmployee(new Employee("PJ", 2000));
            payRoll.AddEmployee(new Employee("MEI", 2000));

            Assert.Equal(800, payRoll.GetTaxes());
        }
    }
}
