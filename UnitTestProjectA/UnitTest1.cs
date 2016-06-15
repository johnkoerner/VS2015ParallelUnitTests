using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTestProjectA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task ATestMethod1()
        {
            await Task.Delay(5000);

        }

        [TestMethod]
        public async Task ATestMethod2()
        {
            await Task.Delay(5000);
        }
    }
}
