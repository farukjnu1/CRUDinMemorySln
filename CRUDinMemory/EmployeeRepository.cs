using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMemory
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1, Name="Taseef",Email="taseef@gmail.com", Department=Dept.IT},
                new Employee(){Id=2, Name="Samin",Email="samin@gmail.com", Department=Dept.HR},
                new Employee(){Id=3, Name="Nabil",Email="nabil@gmail.com", Department=Dept.PayRoll}
            };
        }

        public Employee DeleteEmployee(int id)
        {
            Employee emp = GetEmployeeById(id);
            if (emp != null)
            {
                _employeeList.Remove(emp);
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployeeById(int id)
        {

           Employee employee=(from e in _employeeList where e.Id == id select e).Single();
            return employee as Employee;
        }

        public Employee InsertEmployee(Employee addEmployee)
        {
            Employee emp=((from e in _employeeList orderby e.Id descending select e).Take(1))
                                    .Single() as Employee;
            addEmployee.Id = emp.Id + 1;
            _employeeList.Add(addEmployee);
            return addEmployee;
        }

        public Employee UpdateEmployee(Employee updateEmployee)
        {
            Employee emp = GetEmployeeById(updateEmployee.Id);
            if(emp!=null)
            {
                emp.Name = updateEmployee.Name; 
                emp.Email= updateEmployee.Email;
                emp.Department = updateEmployee.Department;
            }
            return emp;
        }
    }
}
