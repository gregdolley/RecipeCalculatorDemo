using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class RecipeCalcUnitTester
    {
        //[AssemblyInitialize()]
        //public static void AssemblyInit(TestContext context)
        //{
        //    MessageBox.Show("Assembly Init");
        //}

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            MessageBox.Show("ClassInit");
        }

        [TestInitialize()]
        public void Setup()
        {
            MessageBox.Show("Inside Setup...");
        }

        [TestMethod]
        public void TestMethod1()
        {
            MessageBox.Show("Inside TestMethod #1...");
        }

        [TestMethod]
        public void TestMethod2()
        {
            MessageBox.Show("Inside TestMethod #2...");
        }
    }
}
