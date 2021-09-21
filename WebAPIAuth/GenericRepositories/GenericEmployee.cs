using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebAPIAuth.Model;

namespace WebAPIAuth.GenericRepositories
{
    public class GenericEmployee<T> : IGenericEmployee<T> where T : class
    {
        private readonly ApplicationDbContext context;
        DbSet<T> dbset;
        public GenericEmployee(ApplicationDbContext context)
        {
            this.context = context;
            this.dbset = context.Set<T>();
        }
        public T AddEmployee(T t)
        {
            throw new System.NotImplementedException();
        }

        public T DeleteEmployee(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAllEmployee()
        {
            List<Employee> emp;


            if (dbset != null)
            {
                return dbset;
            }
            else
            {
                emp = new List<Employee>()
            {
                new Employee {ID = 1, Age = 23, JoiningDate = DateTime.UtcNow, Name="Johns"}
            };
            }
            return (IEnumerable<T>)emp;
        }

        public IEnumerable<T> AllEmployees()
        {

            var emp = new List<Employee>()
            {
                new Employee {}
            };
            return (IEnumerable<T>)emp;
        }
        public T GetEmployee(int Id)
        {
            throw new System.NotImplementedException();
        }

        public T UpdateEmployee(T t)
        {
            throw new System.NotImplementedException();
        }
    }
}
