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
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                //test
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
