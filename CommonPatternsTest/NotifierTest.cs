using System.ComponentModel;
using CommonPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonPatternsTest
{
   /// <summary>
   /// Summary description for NotifuerTest
   /// </summary>
   [TestClass]
   public class NotifierTest
   {
      //public NotifierTest()
      //{
      //   //
      //   // TODO: Add constructor logic here
      //   //
      //}

      //private TestContext testContextInstance;

      ///// <summary>
      /////Gets or sets the test context which provides
      /////information about and functionality for the current test run.
      /////</summary>
      //public TestContext TestContext
      //{
      //   get
      //   {
      //      return testContextInstance;
      //   }
      //   set
      //   {
      //      testContextInstance = value;
      //   }
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

      private NotifyingInt NoOfDigits;
      private NotifyingInt noOfDigitsCount;

      [TestInitialize]
      public void TestInitialize()
      {
         noOfDigitsCount = new NotifyingInt("noOfDigitsCount");
         NoOfDigits = new NotifyingInt("NoOfDigits");
         NoOfDigits.PropertyChanged += OnPropertyChanged;
      }

    
      [TestCleanup]
      public void TestCleanup()
      {
         NoOfDigits.PropertyChanged -= OnPropertyChanged;
         NoOfDigits = null;
         noOfDigitsCount.PropertyChanged -= OnPropertyChanged;
         noOfDigitsCount = null;
      }

      private void OnPropertyChanged( object sender, PropertyChangedEventArgs e )
      {
         switch( e.PropertyName )
         {
            case "NoOfDigits.Visible":
               noOfDigitsCount.IsVisible = NoOfDigits.IsVisible;
               break;
            case "NoOfDigits.Enabled":
               noOfDigitsCount.IsEnabled = NoOfDigits.IsEnabled;
               break;
            case "NoOfDigits":
               noOfDigitsCount.Value++;
               break;
         }
      }

      [TestMethod]
      public void NotifyingIntConstruction()
      {
         Assert.IsInstanceOfType(NoOfDigits,typeof(NotifyingInt));
      }
      
      [TestMethod]
      public void NotifyingIntVisible() {
         NoOfDigits.IsVisible = true;
         Assert.IsTrue(noOfDigitsCount.IsVisible);
         NoOfDigits.IsVisible = false;
         Assert.IsFalse(noOfDigitsCount.IsVisible);
      }
      
      [TestMethod]
      public void NotifyingIntEnabled()
      {
         NoOfDigits.IsEnabled = true;
         Assert.IsTrue(noOfDigitsCount.IsEnabled);
         NoOfDigits.IsEnabled = false;
         Assert.IsFalse(noOfDigitsCount.IsEnabled);
      }

      [TestMethod]
      public void NotifyingIntValue()
      {
         NoOfDigits.Value= 1;
         Assert.AreEqual(1,noOfDigitsCount.Value);
      }
   }
}
