using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTestProjectB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task BTestMethod1()
        {
            await Task.Delay(5000);

        }

        [TestMethod]
        public async Task BTestMethod2()
        {
            await Task.Delay(5000);
        }
    }
}
