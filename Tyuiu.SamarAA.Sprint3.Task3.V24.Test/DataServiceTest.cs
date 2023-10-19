using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint3.Task3.V24.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "gft hggt ntg";
            char chr = 'g';
            char chrr = '*';

            string res = ds.ReplaceCharInString(str, chr, chrr);
            string wait = "*ft h**t nt*";

            Assert.AreEqual(wait, res);

        }
    }
}
