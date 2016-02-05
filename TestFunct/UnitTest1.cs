using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvertChart;
using System.Text;

namespace TestFunct
{
    [TestClass]
    public class TestFunct
    {
        [TestMethod]
        public void RevertSrt()
        {
            var t = new Revert();
            StringBuilder test = new   StringBuilder("fgh/345");
            var result = t.RevertString(new StringBuilder("hgf/543"));
            Assert.AreEqual(test.ToString(), result.ToString());
        }

        
    }
}
