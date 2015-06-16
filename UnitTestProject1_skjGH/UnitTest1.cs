using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubTeamWorkDemo;

namespace UnitTestProject1_skjGH
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Print_skjGH_06162015();
            Assert.IsTrue(true);
        }
    }
}
