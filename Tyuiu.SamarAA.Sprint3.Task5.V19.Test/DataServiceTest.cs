using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint3.Task5.V19.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int strtv1 = 1;
            int stpv1 = 3;
            int strtv2 = 1;
            int stpv2 = 6;

            double res = ds.GetSumSumSeries(x, strtv1, strtv2, stpv1, stpv2);
            double wait = 30598.002;

            Assert.AreEqual(wait, res);
        }
    }
}
