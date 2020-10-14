using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryApplication;

namespace LibraryAppTest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("A Test Password", class1.testOfPassword());
        }
    }
}
