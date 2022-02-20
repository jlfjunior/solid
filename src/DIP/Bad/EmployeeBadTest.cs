using System;
using Xunit;

namespace DIP.Bad
{
    public class EmployeeGoodTest
    {
        [Fact]
        public void Hired()
        {
            var employeeOne = new Employee("Joao", 1000);

            Assert.Equal(DateTime.Today.Date, employeeOne.HiredAt.Date);
        }
    }
}
