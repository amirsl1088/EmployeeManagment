using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Manager:Employee
    {
        public Manager(int employeeid,int salary):base(employeeid,salary)
        {

        }
        public string Depatment { get; set; }
        public override void PrintDetails()
        {
            Console.WriteLine($"employee id={EmployeeID}, salary={Salary}, department={Depatment}");
        }
    }
}
