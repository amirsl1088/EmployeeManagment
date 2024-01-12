using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Employee
    {
        public Employee(int employeeid,int salary)
        {
            EmployeeID = employeeid;
            Salary = salary;
        }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"employee id={EmployeeID}, salary={Salary}");
        }
    }
}
