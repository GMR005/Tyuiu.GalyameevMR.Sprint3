using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task0.V26.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task0.V26. Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckRange()
        {
            DataService DataService = new DataService();
            double value = -0.2272020947;
            int startValue = 1;
            int stopValue = 9;
            double x = DataService.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(-15.642, x);
        }
    }
}
