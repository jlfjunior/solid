namespace OCP.Good
{
    public class CLT : Employee
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
