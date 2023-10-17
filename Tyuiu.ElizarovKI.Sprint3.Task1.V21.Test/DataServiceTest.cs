using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint3.Task1.V21.Lib;

namespace Tyuiu.ElizarovKI.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 12;
            double value = 1;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 98.339;

            Assert.AreEqual(wait, res);
        }
    }
}
