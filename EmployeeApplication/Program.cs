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
            EmployeeLogic employeeLogic = new EmployeeLogic();

            employeeLogic.AddEmployee(new Employee(1000, "James", "Software engineering", 80000));
            employeeLogic.AddEmployee(new Employee(2000, "Tim", "Quality Assuarance", 70000));
            employeeLogic.AddEmployee(new Employee(3000, "Bob", "Human Resource Dept", 75000));
            employeeLogic.AddEmployee(new Employee(4000, "Mike", "Accounting", 80000));
            employeeLogic.AddEmployee(new Employee(5000, "Frank", "R n D Dept", 90000));


            List<Employee> list = employeeLogic.GetEmployees();


            Account account = new Account();
            foreach (Employee e in list)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");

                account.CalculateSalary(e);
                account.showCompensation(e);
                Console.WriteLine("-----------------------------------------------------------------------------------");

                e.displayEmployeeDetails();
            }


            Employee employee = new Manager(1000, "James", "Software Engineer", 400000, 20000, 15000);
            Employee employee1 = new SalesManager(2000, "Chris", "Software Engineer", 400000, 7000, 15000, 5000);
            Employee employee2 = new Engineer(3000, "Tim", "Software Engineer", 400000, 2500, 5, "In Progress");



            

            Console.WriteLine("-----------------------------------------------------------------------------------");
            account.CalculateSalary(employee);
            account.showCompensation(employee);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            
            Console.WriteLine("-----------------------------------------------------------------------------------");
            account.CalculateSalary(employee1);
            account.showCompensation(employee1);
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine("-----------------------------------------------------------------------------------");
            account.CalculateSalary(employee2);
            account.showCompensation(employee2);
            Console.WriteLine("-----------------------------------------------------------------------------------");






        }
    }
}
