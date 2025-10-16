using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.BalinVV.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.BalinVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Валерий";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Валерий",res);
        }
    }
}
