using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Data;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Property
        public EmployeeService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetEmployeeById(int EmpId)
        {
            var name = await _apiDbContext.Employee.Where(c => c.Id == EmpId).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpId)
        {
            var emp = await _apiDbContext.Employee.FirstOrDefaultAsync(c => c.Id == EmpId);
            return emp;
        }
    }
}
