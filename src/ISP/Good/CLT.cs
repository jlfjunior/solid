using ISP.Good.Interfaces;

namespace ISP.Good
{
    public class CLT : Employee, ITaxable, ISalary
    {
        private const string Description = "CLT";
        private const decimal Tax = 0.2m;

        public CLT(string fullName, decimal salary) : base(fullName, salary) { }

        public decimal CalculateTax()
        {
            return Salary * Tax;
        }

        public decimal CalculateNetSalary()
        {
            return Salary * 0.9m;
        }
    }
}
