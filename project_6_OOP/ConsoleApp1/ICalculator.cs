using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculator
    {
        public double Add(double n1, double n2);
        public double Sub(double n1, double n2);
        public double Mul(double n1, double n2);
        public double Div(double n1, double n2);


    }
}
