using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMemory
{
    internal class Program
    {
        static EmployeeRepository repo = new EmployeeRepository();       

        static void Main(string[] args)
        {
			try
			{
				DoWork();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
            Console.ReadLine();
            Console.ReadKey();
        }

        private static void DoWork()
        {
            string operation = "";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tMy Application\r");
            Console.WriteLine("\t\t\t\t---------------\n");
            Console.WriteLine("How many operation do you want to perform");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("\t\t\t\t--Select operation: (Select ,Add, Edit, Delete).....\n");
                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "Select":
                            ShowEmployee(null);
                            break;
                        case "Add":
                            AddEmployee();
                            break;
                        case "Edit":
                            UpdateEmployee();
                            break;
                        case "Delete":
                            DeleteEmployee();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private static void DeleteEmployee()
        {
            Employee delEmployee = new Employee();
            delEmployee.Id = 3;
            repo.DeleteEmployee(delEmployee.Id);
            Console.WriteLine("Employee deleted Successfully");
            ShowEmployee(null);
        }

        private static void UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.Name = "Monisha";
            employee.Email = "nnn@hotmail.com";
            employee.Department = Dept.PayRoll;
            employee.Id = 4;
            repo.UpdateEmployee(employee);
            Console.WriteLine("Employee updated Successfully");
            ShowEmployee(null);
        }

        private static void AddEmployee()
        {
            Employee employee = new Employee();
            employee.Name = "nnn";
            employee.Email = "nnn@gmail.com";
            employee.Department = Dept.HR;
            repo.InsertEmployee(employee);
            Console.WriteLine("Employee Saved Successfully");
            ShowEmployee(null);
        }

        private static void ShowEmployee(Employee employee)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine(string.Format("|{0,5}|{1,10}|{2,-20}|{3,10}","ID","Name","Email","Department"));
            Console.WriteLine();
            list = repo.GetAllEmployee().ToList();
            foreach (var item in list)
            {
                Console.WriteLine(string.Format("|{0,5}|{1,10}|{2,-20}|{3,10}", item.Id, item.Name, item.Email, item.Department));
                
            }
            Console.WriteLine();
        }
    }
}
