using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task7.V8.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckTabValid()
        {
            DataService DataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = -8.858;
            wait[1] = -7.185;
            wait[2] = -6.139;
            wait[3] = -4.763;
            wait[4] = -2.328;
            wait[5] = 1.0;
            wait[6] = 4.382;
            wait[7] = 0.0;
            wait[8] = 6.131;
            wait[9] = 7.07;
            wait[10] = 8.613;
            double[] res = DataService.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(res, wait);





        }
    }
}
