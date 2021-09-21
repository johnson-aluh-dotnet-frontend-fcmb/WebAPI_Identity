using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIAuth.Model;

namespace WebAPIAuth.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        List<Employee> emp;
        public EmployeeRepo()
        {
            emp = new List<Employee>()
            {
                new Employee {ID = 1, Age = 23, JoiningDate = DateTime.UtcNow, Name="Johns"}
            };
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.ID = emp.Max(e => e.ID) + 1;
            emp.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int Id)
        {
            var employee = emp.FirstOrDefault(e => e.ID == Id);
            if (employee != null)
            {
                emp.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return emp;
        }

        public Employee GetEmployee(int Id)
        {
            var employee = emp.FirstOrDefault(e => e.ID == Id);
            if (employee != null)
            {
                return employee;
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employi = emp.FirstOrDefault(e => e.ID == employee.ID);
            if (employee != null)
            {
                employi.ID = employee.ID;
            }
            return employee;
        }
    }
}
