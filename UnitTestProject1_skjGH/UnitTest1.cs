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

        [TestMethod]
        public void TestMethod2()
        {
 		    Test1_skjGH test = new 
                Test1_skjGH("skjGH 06172015");
            test.Print();
            Assert.IsTrue(true);        
        }

    }
}
