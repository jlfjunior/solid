using Xunit;

namespace OCP.Bad
{
    public class PayrollBadTest
    {
        [Fact]
        public void ShouldCalculateTotalValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("Joao", "CLT", 1000));
            payRoll.AddEmployee(new Employee("Maria", "PJ", 2000));
            payRoll.AddEmployee(new Employee("Jose", "MEI", 2000));

            Assert.Equal(5300, payRoll.GetTotalValue());
        }

        [Fact]
        public void ShouldCalculateNetValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("Joao", "CLT", 1000));
            payRoll.AddEmployee(new Employee("Maria", "PJ", 2000));
            payRoll.AddEmployee(new Employee("Jose", "MEI", 2000));

            Assert.Equal(4500, payRoll.GetNetValue());
        }

        [Fact]
        public void ShouldCalculateTaxesValue()
        {
            var payRoll = new Payroll();
            payRoll.AddEmployee(new Employee("Joao", "CLT", 1000));
            payRoll.AddEmployee(new Employee("Maria", "PJ", 2000));
            payRoll.AddEmployee(new Employee("Jose", "MEI", 2000));

            Assert.Equal(800, payRoll.GetTaxes());
        }
    }
}
