using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 60;
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(2, result);
        }
    }
}
