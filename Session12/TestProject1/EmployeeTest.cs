using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Services;
using UnitTest_Mock.Models;
using System;
using Xunit;

namespace TestProject1
{
    public class EmployeeTest
    {
        #region Property
        private Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        public static void Main(string[] args) { }

        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Desgination = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
