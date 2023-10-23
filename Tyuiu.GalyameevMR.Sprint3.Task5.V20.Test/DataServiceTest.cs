using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task5.V20.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumInSumValid()
        {
            DataService DataService = new DataService();
            int x = 5;
            int startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 6;
            double sum = DataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(50584.322, sum);




        }
    }
}
