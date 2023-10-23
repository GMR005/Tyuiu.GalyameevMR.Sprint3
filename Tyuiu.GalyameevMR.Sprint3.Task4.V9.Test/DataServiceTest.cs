using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task4.V9.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalcValid()
        {
            DataService DataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = DataService.Calculate(startValue, stopValue);
            Assert.AreEqual(res, 1.59);
        }
    }
}
