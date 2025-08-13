using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMemory
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee InsertEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
    }
}
