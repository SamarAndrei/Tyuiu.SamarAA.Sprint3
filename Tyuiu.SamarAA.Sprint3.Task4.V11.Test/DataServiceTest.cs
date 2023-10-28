using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint3.Task4.V11.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.186;

            Assert.AreEqual(wait, res);
        }
    }
}
