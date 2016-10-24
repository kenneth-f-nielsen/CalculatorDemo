using CalculatorDll.Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest.UnitTest
{
   /// <summary>
   /// Summary description for CalculatorControllerTest
   /// </summary>
   [TestClass]
   public class CalculatorControllerTest
   {
      private CalculatorController calculator;
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
         calculator = new CalculatorController();
      }

      [TestCleanup]
      public void TestCleanup()
      {
         calculator = null;
      }

      [TestMethod]
      public void DivideWithZeroExpectException()
      {
         double d = calculator.Divide(1, 0);
         Assert.AreEqual(double.NaN, d);
      }
      [TestMethod]
      public void AddOnePlusTwoExpectThree()
      {
         double d = calculator.Divide(1, 2);
         Assert.AreEqual(3, d);
      }
   }
}
