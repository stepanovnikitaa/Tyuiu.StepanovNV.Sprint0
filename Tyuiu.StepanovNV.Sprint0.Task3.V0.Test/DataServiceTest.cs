using System;
using Tyuiu.StepanovNV.Sprint0.Task3.V0.Lib;


namespace Tyuiu.StepanovNV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
