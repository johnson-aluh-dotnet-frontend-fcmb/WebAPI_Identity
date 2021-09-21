using System.Collections.Generic;

namespace WebAPIAuth.GenericRepositories
{
    public interface IGenericEmployee<T> where T : class
    {
        T GetEmployee(int Id);
        IEnumerable<T> GetAllEmployee();
        T AddEmployee(T t);
        T UpdateEmployee(T t);
        T DeleteEmployee(int Id);
    }
}
