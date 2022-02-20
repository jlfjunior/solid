namespace OCP.Bad
{
    public class Employee
    {
        public string FullName { get; private set; }
        public decimal Salary { get; private set; }
        public string ContractType { get; private set; }

        public Employee(string fullName, string contractType, decimal salary)
        {
            FullName = fullName;
            ContractType = contractType;
            Salary = salary;
        }

        public decimal CalculateNetSalary()
        {
            return Salary * 0.9m;
        }

        public decimal CalculateTax()
        {
            if (ContractType == "CLT")
            {
                return Salary * 0.2m;
            }

            if (ContractType == "PJ")
            {
                return Salary * 0.1m;
            }

            if (ContractType == "MEI")
            {
                return Salary * 0.0m;
            }

            return 0;
        }
    }
}
