using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 1;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(-2, res);
        }
    }
}
