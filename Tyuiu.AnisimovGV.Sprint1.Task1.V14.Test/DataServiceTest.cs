using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AnisimovGV.Sprint1.Task1.V14.Lib;


namespace Tyuiu.AnisimovGV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 12.0;
            double b = 4.0;
            double c = 2.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(26, res);
        }
    }
}
