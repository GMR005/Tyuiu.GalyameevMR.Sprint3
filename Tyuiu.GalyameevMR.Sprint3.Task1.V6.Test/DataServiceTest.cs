using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task1.V6.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSum()
        {
            DataService DataService = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double sum = DataService.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(sum, -389102.25);
        }
    }
}
