using ISP.Good.Interfaces;

namespace ISP.Good
{
    public class PJ : Employee, ISalary
    {
        private const string Description = "PJ";
        private const decimal Tax = 0.1m;

        public PJ(string fullName, decimal salary) : base(fullName, salary) { }

        public decimal CalculateNetSalary()
        {
            return Salary;
        }
    }
}
