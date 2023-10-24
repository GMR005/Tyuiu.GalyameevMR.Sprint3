using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task6.V3.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckParts()
        {
            DataService DataService = new DataService();
            int startValue = 13;
            int stopValue = 19;
            int sum = DataService.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(sum, 121);
        }
    }
}
