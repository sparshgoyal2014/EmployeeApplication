using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication.Model;

namespace EmployeeApplication.Logic
{
    public class EmployeeLogic
    {
        private List<EmployeeApplication.Model.Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }


        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> UpdateEmployee(int empNo, Employee employee)
        {

            int size = employees.Count;

            for(int i=0; i<size; i++)
            {
                if (employees[i].EmpNo == empNo)
                {
                    employees[i] = employee;
                    break;
                }
            }
            
            return employees;
        }

        public List<Employee> DeleteEmployee(int empNo)
        {

            for(int i=0; i<employees.Count; i++)
            {
                if (employees[i].EmpNo == empNo)
                {

                    employees.RemoveAt(i);
                    break;
                }
            }
            return employees;

        }


        public List<Employee> SearchEmployee(string dName)
        {

            for(int i=0; i<employees.Count; i++)
            {
                if (employees[i].EmpName.Equals(dName))
                {
                    employees[i].displayEmployeeDetails();
                }
            }

            return employees;
        }






    }
}
