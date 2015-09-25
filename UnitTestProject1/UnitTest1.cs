using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Premutator("12").GetCollected();
            Assert.IsTrue(p.Contains("12"));
            Assert.IsTrue(p.Contains("21"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var p = new Premutator("123").GetCollected();
            Assert.IsTrue(p.Contains("123"));
            Assert.IsTrue(p.Contains("213"));
            Assert.IsTrue(p.Contains("321"));
            Assert.IsTrue(p.Contains("312"));
            Assert.IsTrue(p.Contains("321"));
            Assert.IsTrue(p.Contains("312"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var p = new Premutator("носки").GetCollected();
            Assert.IsTrue(p.Contains("носик"));
            Assert.IsTrue(p.Contains("оникс"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var p = new Premutator("РОГБЕДОЛ").GetCollected();
            Assert.IsTrue(p.Contains("БЕЛГОРОД"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            var p = new Premutator("ДАМРДИ").GetCollected();
            Assert.IsTrue(p.Contains("МАДРИД"));
        }
    }
}
