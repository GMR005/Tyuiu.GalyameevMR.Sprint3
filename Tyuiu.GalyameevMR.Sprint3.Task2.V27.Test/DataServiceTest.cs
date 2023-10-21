using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task2.V27.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService DataService = new DataService();
            double x = 4.0;
            int startValue = 1;
            int stopValue = 14;
            double value = 0.667;
            double sum = DataService.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(1.994, sum);

        }
    }
}
