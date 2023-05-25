using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyEmployee:Person
    {
        public double Salary { get;  }
        public MyEmployee(double basic) 
        {
            Salary = basic;
        }
        public double TotalSalary(double bonus)
        {
            return Salary+bonus;
        }
        public double TotalSalary(double bonus, double HR)
        {
            
            return Salary+bonus + HR;
        }
        public double TotalSalary(double Bonus, double HR, double PF)
        {
            return Salary+Bonus+HR+PF;
        }
      
    }
}
