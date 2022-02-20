using ISP.Good.Interfaces;

namespace ISP.Good
{
    public class MEI : Employee, ISalary
    {
        private const string Description = "MEI";
        private const decimal Tax = 0.0m;

        public MEI(string fullName, decimal salary) : base(fullName, salary) { }

        public decimal CalculateNetSalary()
        {
            return Salary;
        }
    }
}
