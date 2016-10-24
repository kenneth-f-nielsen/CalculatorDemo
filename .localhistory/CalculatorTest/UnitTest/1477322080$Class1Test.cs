using CalculatorDll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest.UnitTest
{
    [TestClass]
    public class Class1Test
    {
        private Class1 class1;
        public Class1Test()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //private TestContext testContextInstance;

        ///// <summary>
        /////Gets or sets the test context which provides
        /////information about and functionality for the current test run.
        /////</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void TestInitialize()
        {
            class1 = new Class1();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            class1 = null;
        }

        [TestMethod]
        public void SucceedingTest()
        {
            Assert.IsInstanceOfType(class1,typeof(Class1));
            class1.a = 0;
            Assert.AreEqual(0,class1.a);
        }
    }
}
