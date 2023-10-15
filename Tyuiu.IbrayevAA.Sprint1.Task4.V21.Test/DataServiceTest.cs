using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task4.V21.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}
