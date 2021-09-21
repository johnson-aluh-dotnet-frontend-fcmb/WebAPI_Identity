using System.Collections.Generic;
using WebAPIAuth.Model;

namespace WebAPIAuth.Repositories
{
    public class SqlEmployeeRepo : IEmployeeRepo
    {
        public ApplicationDbContext context;

        public SqlEmployeeRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int Id)
        {
            var employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return employee;

            }
            //var emp = new List<Employee>() { new Employee {Name = "This employee Id" + Id + " does not exist"} };
            return employee;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            var employee = context.Employees.Find(Id);
            if (employee != null)
            {
                return employee;
            }

            return null;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = context.Employees.Attach(employee);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return employee;

        }
    }
}
