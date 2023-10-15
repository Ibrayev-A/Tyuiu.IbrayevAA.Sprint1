using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task0.V5.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(12, res);
        }
    }
}
