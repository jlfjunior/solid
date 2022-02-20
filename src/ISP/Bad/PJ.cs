namespace ISP.Bad
{
    public class PJ : Employee
    {
        private const string Description = "PJ";
        private const decimal Tax = 0.1m;

        public PJ(string fullName, decimal salary) : base(fullName, salary) { }

        public override decimal CalculateTax()
        {
            return Salary * Tax;
        }
    }
}
