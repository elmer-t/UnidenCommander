using UnidenCommander.Scanner.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for ScannerNotSupportedExceptionTest and is intended
    ///to contain all ScannerNotSupportedExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScannerNotSupportedExceptionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ScannerNotSupportedException Constructor
        ///</summary>
        [TestMethod()]
        public void ScannerNotSupportedExceptionConstructorTest()
        {
            string model = string.Empty; // TODO: Initialize to an appropriate value
            ScannerNotSupportedException target = new ScannerNotSupportedException(model);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
