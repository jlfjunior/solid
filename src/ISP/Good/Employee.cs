using System;

namespace ISP.Good
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public decimal Salary { get; private set; }

        public Employee(string fullName, decimal salary)
        {
            FullName = fullName;
            Salary = salary;
        }

        //public decimal CalculateNetSalary()
        //{
        //    return Salary * 0.9m;
        //}
    }
}
