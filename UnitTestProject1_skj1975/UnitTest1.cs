using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubTeamWorkDemo;


namespace UnitTestProject1_skj1975
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Print_skj1957_06162015();
            Assert.IsTrue(true);
        }
    }
}
