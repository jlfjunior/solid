namespace SRP.Bad
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
    }
}
