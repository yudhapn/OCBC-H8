using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        public Task<string> GetEmployeeById(int EmpId);
        public Task<Employee> GetEmployeeDetails(int EmpId);
    }
}
