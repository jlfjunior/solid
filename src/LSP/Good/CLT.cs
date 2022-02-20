namespace LSP.Good
{
    public class CLT : Tax
    {
        private const string Description = "CLT";
        private const decimal Tax = 0.2m;

        public CLT(string fullName, decimal salary) : base(fullName, salary) { }

        public override decimal CalculateTax()
        {
            return Salary * Tax;
        }
    }
}
