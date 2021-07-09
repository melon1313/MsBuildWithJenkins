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
                //changes with error
                Console.SetOut(sw);
                Program.Main();

                10/5

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
