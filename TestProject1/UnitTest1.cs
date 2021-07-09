using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsBuildWithJenkins;
using System;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Hello Alice!";

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(true);
        }
    }
}
