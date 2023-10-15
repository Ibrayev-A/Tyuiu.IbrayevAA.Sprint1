using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IbrayevAA.Sprint1.Task1.V2.Lib
{
    public class DataService : ISprint1Task1V2
    {
        public double Calculate(double x, double y)
        {
            return x * y / (5 + x);
        }
    }
}
