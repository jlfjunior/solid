using System.Collections.Generic;

namespace SRP.Bad
{
    public class Payroll
    {
        public ICollection<Employee> Employees { get; private set; }

        public Payroll() 
        {
            Employees = new List<Employee>(); 
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public decimal GetNetValue()
        {
            var value = 0m;

            foreach (var employee in Employees)
            {
                value += employee.Salary * 0.9m;
            }

            return value;
        }

        public decimal GetTotalValue()
        {
            return GetNetValue() + GetTaxes();
        }

        public decimal GetTaxes()
        {
            var value = 0m;

            foreach (var employee in Employees)
            {
                if (employee.ContractType == "CLT")
                {
                    value += employee.Salary * 0.2m;
                }

                if (employee.ContractType == "PJ")
                {
                    value += employee.Salary * 0.1m;
                }

                if (employee.ContractType == "MEI")
                {
                    value += employee.Salary * 0.0m;
                }
            }

            return value * 2;
        }
    }
}
