using System;

namespace DIP.Good
{
    public class Employee
    {
        public string FullName { get; set; }
        public decimal Salary { get; private set; }
        public DateTime HiredAt { get; private set; }

        public Employee(string fullName, decimal salary, DateTime hiredAt)
        {
            FullName = fullName;
            Salary = salary;
            HiredAt = hiredAt;
        }

        public decimal CalculateNetSalary()
        {
            return Salary * 0.9m;
        }

        public virtual decimal CalculateTax() => throw new NotImplementedException();
    }
}
