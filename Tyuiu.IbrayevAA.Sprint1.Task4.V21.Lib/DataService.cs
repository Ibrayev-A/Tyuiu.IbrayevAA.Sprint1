using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IbrayevAA.Sprint1.Task4.V21.Lib
{
    public class DataService : ISprint1Task4V21
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Abs( Math.Pow((1 + x), 2) - y) / (x + y);
            return Math.Round(res, 3);
        }
    }
}
