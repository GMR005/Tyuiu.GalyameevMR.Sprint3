using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint3.Task3.V5.Lib;
namespace Tyuiu.GalyameevMR.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckTextReplace()     
        {
            DataService DataService = new DataService();
            string a = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';
            string value = DataService.ReplaceCharInString(a, replaceable, replacement);
            Assert.AreEqual(value, "fif* *l f*ll");
        }
    }
}
