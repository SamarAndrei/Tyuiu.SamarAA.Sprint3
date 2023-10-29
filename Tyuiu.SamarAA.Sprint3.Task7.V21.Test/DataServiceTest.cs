using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint3.Task7.V21.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startV = -5;
            int stopV = 5;

            int len = stopV - startV + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 28.05;
            valueWaitArray[1] = 22.27;
            valueWaitArray[2] = 17.01;
            valueWaitArray[3] = 12.35;
            valueWaitArray[4] = 7.51;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 1.62;
            valueWaitArray[7] = -7.03;
            valueWaitArray[8] = -12.99;
            valueWaitArray[9] = -17.55;
            valueWaitArray[10] = -21.43;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startV, stopV);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
