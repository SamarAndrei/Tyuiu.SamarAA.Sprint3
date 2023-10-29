using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint3.Task6.V28.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startV = 13;
            int stopV = 19;
            int res = ds.GetSumTheDivisors(startV, stopV);
            int wait = 15;

            Assert.AreEqual(wait, res);
        }
    }
}
