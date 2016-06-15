using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTestProjectC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task CTestMethod1()
        {
            await Task.Delay(5000);
        }

        [TestMethod]
        public async Task CTestMethod2()
        {
            await Task.Delay(5000);
        }
    }
}
