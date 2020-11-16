using System;
using Demo1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Logic LogicTest = new Logic();

        [TestMethod]
        public void TestMethod1()
        {
            int Test = LogicTest.LoadGun();
            Assert.AreEqual(0, Test);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int Test = LogicTest.SpinGun();
            Assert.IsTrue(Test<6 );
        }
    }
}
