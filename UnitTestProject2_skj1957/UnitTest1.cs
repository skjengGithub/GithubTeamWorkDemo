using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GithubTeamWorkDemo;

namespace UnitTestProject2_skj1957
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test1_skj1957 test = new Test1_skj1957("skj1957 06172015");
            test.Print();
            Assert.IsTrue(true);
        }
    }
}
