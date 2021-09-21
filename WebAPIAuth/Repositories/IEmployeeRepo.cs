using System.Collections.Generic;
using WebAPIAuth.Model;

namespace WebAPIAuth.Repositories
{
    public interface IEmployeeRepo
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int Id);
    }
}
