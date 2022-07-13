using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication.Model;

namespace EmployeeApplication
{
    public class Account
    {

        public double CalculateSalary(Employee employee)
        {
            return employee.CalculateNetSalary(); 
        }

        public void showCompensation(Employee employee)
        {
            Console.WriteLine($"Employee NO. {employee.EmpNo}/{employee.EmpName} Salary Details");
            Console.WriteLine($"Gross Salary including allowances: {employee.GrossSalary}");
            Console.WriteLine($"Tax Deduction: {employee.CalculateTax()}");
            Console.WriteLine($"Net Salary is GROSS SALARY - TAX DEDUCTION which is: {employee.CalculateNetSalary()}");
        }

    }
}
