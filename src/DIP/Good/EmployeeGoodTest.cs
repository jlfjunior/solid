using System;
using Xunit;

namespace DIP.Good
{
    public class EmployeeGoodTest
    {
        [Fact]
        public void Hired()
        {
            var employeeOne = new Employee("Joao", 1000, DateTime.Today);

            Assert.Equal(DateTime.Today.Date, employeeOne.HiredAt.Date);
        }
    }
}
