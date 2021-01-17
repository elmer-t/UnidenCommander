using UnidenCommander.Scanner.CommandSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnidenCommander.Scanner;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for ScannerCommandSet785Test and is intended
    ///to contain all ScannerCommandSet785Test Unit Tests
    ///</summary>
    [TestClass()]
    public class ScannerCommandSet785Test
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
        ///A test for LCDLines
        ///</summary>
        [TestMethod()]
        public void LCDLinesTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            ScannerCommandSet785 target = new ScannerCommandSet785(connection); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.LCDLines();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FillScannerModes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void FillScannerModesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ScannerCommandSet785_Accessor target = new ScannerCommandSet785_Accessor(param0); // TODO: Initialize to an appropriate value
            target.FillScannerModes();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Channel
        ///</summary>
        [TestMethod()]
        public void ChannelTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            ScannerCommandSet785 target = new ScannerCommandSet785(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Channel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScannerCommandSet785 Constructor
        ///</summary>
        [TestMethod()]
        public void ScannerCommandSet785ConstructorTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            ScannerCommandSet785 target = new ScannerCommandSet785(connection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
