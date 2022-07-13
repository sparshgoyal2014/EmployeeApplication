using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication.Logic;
using EmployeeApplication.Model;


namespace EmployeeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeLogic employeeLogic = new EmployeeLogic();

            //employeeLogic.AddEmployee(new Employee(1000, "James", "Software engineering", 80000));
            //employeeLogic.AddEmployee(new Employee(2000, "Tim", "Quality Assuarance", 70000));
            //employeeLogic.AddEmployee(new Employee(3000, "Bob", "Human Resource Dept", 75000));
            //employeeLogic.AddEmployee(new Employee(4000, "Mike", "Accounting", 80000));
            //employeeLogic.AddEmployee(new Employee(5000, "Frank", "R n D Dept", 90000));


            //List<Employee> list = employeeLogic.GetEmployees();

            //foreach(Employee e in list)
            //{
            //    e.displayEmployeeDetails();
            //}


            Employee employee = new Manager(1000, "James", "Software Engineer", 400000);

            Account account = new Account();
            account.CalculateSalary(employee);
            account.showCompensation(employee);



        }
    }
}
