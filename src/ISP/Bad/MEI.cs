namespace ISP.Bad
{
    public class MEI : Employee
    {
        private const string Description = "MEI";
        private const decimal Tax = 0.0m;

        public MEI(string fullName, decimal salary) : base(fullName, salary) { }

        public override decimal CalculateTax()
        {
            return Salary * Tax;
        }
    }
}
