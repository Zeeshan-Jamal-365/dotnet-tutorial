using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee:Person
    {
        private double Basic;
        public string Department { get; set; }
        public string Designation{ get; set; }
        public double  Salary{ get;  }
        public double basic;
        
        public Employee()
        {
        }
        //public Employee(int id,string name, string Phone,string Email, string Address, string dept, string desg,double salary) 
        //{                            
                                     
        //    dept = Department;
        //    desg =Designation ;
        //    salary =     Salary ;
        //    id = Id;
        //    name = Name;
        //    Phone= Phone;
        //    Email= Email;
        //    Address= Address;


        //}
        public Employee(double basic)
        {
            Salary = basic;
        }
        private double HR()
        {
            return Salary * 50 / 100;
        }
        private double Ma()
        {
            return Salary * 10 / 100;
        }
        private double PF()
        {
            return Salary * 5 / 100;
        }
        private double Ta()
        {
            return Salary * 5 / 100;
        }
        public double Total()
        {
            return Salary +HR()+Ma()+Ta() - PF();
        }

    }
}
