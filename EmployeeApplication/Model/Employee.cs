using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Model
{
    public class Employee
    {

        public string EmpName { get; set; }
        public int EmpNo { get; set; }
        public string DeptName { get; set; }
        public decimal BasicSalary { get; set; }

        public decimal GrossSalary{get; set;}

        public Employee(int empNo, string empName, string deptName, decimal salary)
        {
            EmpName = empName;
            EmpNo = empNo;
            DeptName = deptName;
            BasicSalary = salary;
            GrossSalary = salary;
        }

        public void displayEmployeeDetails()
        {
            Console.WriteLine($"Name of the Employee: {EmpName} " +
                $"Employee Number: {EmpNo} " +
                $"Department {DeptName} ");
        }


        protected decimal CalculateSalary()
        {

            return this.BasicSalary;
        }

       
        protected virtual decimal calcGrossSalary()
        {
            return this.GrossSalary;
        }

        public double CalculateTax()
        {
            decimal grossSalary = this.GrossSalary;

            if (grossSalary < 100000)
            {
                return 0;
            }
            else
            {
                if (grossSalary >= 100000 && grossSalary < 500000)
                {
                    return 0.2 * (double)grossSalary;
                }
                else if (grossSalary >= 500000 && grossSalary <= 100000)
                {
                    return 0.3 * (double)grossSalary;
                }
                else
                {
                    return 0.4 * (double)grossSalary;
                }
            }


        }

        public double CalculateNetSalary()
        {
            double netSalary =  (double)calcGrossSalary() - CalculateTax();
            Console.WriteLine($"Net Salary of Employee. {EmpNo} -> {EmpName} is {netSalary}");
            return netSalary;
        }


        public void displayNetSalary()
        {
            Console.WriteLine($"Net Salary of the Employee '{EmpNo}' is: {CalculateNetSalary()}");
        }

    }


    public class Manager : Employee
    {

        public decimal TravelAllowance { get; set; }
        public decimal ProjectAllowance { get; set; }

        public Manager(int empNo, string empName, string deptName, decimal salary) : base(empNo, empName, deptName, salary){}


        public Manager(int empNo, string empName, string deptName, decimal salary, decimal tracelAllowance, decimal projectAllowance) : base(empNo, empName, deptName, salary)
        {
            TravelAllowance = tracelAllowance;
            ProjectAllowance = projectAllowance;
        }

        protected override decimal calcGrossSalary()
        {
            return GrossSalary = this.CalculateSalary() + this.TravelAllowance + this.ProjectAllowance;

        }

    }


    class SalesManager : Manager 
    {

        public decimal PetrolAllowance { get; set; }
        public decimal HotelAllowance { get; set; }
        public decimal CustomExpenses { get; set; }
        
        public SalesManager(int empNO, string empName, string deptName, decimal salary, decimal petrolAllowance, decimal hotelAllowance, decimal customExpenses): base(empNO, empName, deptName, salary)
        {
            PetrolAllowance = petrolAllowance;
            HotelAllowance = hotelAllowance;
            CustomExpenses = customExpenses;
        }


        protected override decimal calcGrossSalary()
        {
            return GrossSalary = this.CalculateSalary() + PetrolAllowance + HotelAllowance + CustomExpenses;

        }

    }


    class Engineer: Employee
    {
        public int OverTime { get; set; } // amount per hour for the over time

        public string Status { get; set; } // Status of the task the employee is doing in overtime.

        public int OverTimeHours { get; set; } // how much over time did the employee worked
        public Engineer(int empNO, string empName, string deptName, decimal salary, int overTime, int overTimeHours, string status) : base(empNO, empName, deptName, salary)
        {
            OverTime = overTime;
            OverTimeHours = overTimeHours;
            Status = status;
        }


        protected override decimal calcGrossSalary()
        {

            if(Status == "In Progress" || Status == "Completed")
            {

                return GrossSalary = this.CalculateSalary() + OverTimeHours * OverTime;
                
            }

            return GrossSalary;

        }

        
    }
    

}
