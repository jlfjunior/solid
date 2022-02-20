namespace SRP.Good
{
    public class Employee
    {
        public decimal Salary { get; private set; }
        public string ContractType { get; private set; }

        public Employee(string contractType, decimal salary)
        {
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
