using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculation calculation = new Calculation();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.Inconclusive("暂时无法测试");

            int x = 49, y = 51;
            Assert.AreEqual(calculation.sum(x, y), x + y + 1);

            //Assert.AreEqual(calculation.subtract(x, y), x - y + 1);


        }
    }
}
