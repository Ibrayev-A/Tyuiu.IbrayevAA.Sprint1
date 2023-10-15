using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint1.Task2.V27.Lib;

namespace Tyuiu.IbrayevAA.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            var res = ds.CalculateSquarePerimetr(value);
            Assert.AreEqual(8, res);
        }
    }
}
