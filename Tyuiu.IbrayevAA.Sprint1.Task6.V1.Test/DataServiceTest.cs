using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string restest = "1";
            DataService ds = new DataService();
            string res = ds.SymbolCode(restest);
            Assert.AreEqual("49", res);

        }
    }
}
