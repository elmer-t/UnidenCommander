using UnidenCommander.Scanner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for ScannerTest and is intended
    ///to contain all ScannerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScannerTest
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
        ///A test for InitializeCommandSet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeCommandSetTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Scanner_Accessor target = new Scanner_Accessor(param0); // TODO: Initialize to an appropriate value
            ScannerModels model = new ScannerModels(); // TODO: Initialize to an appropriate value
            target.InitializeCommandSet(model);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Disconnect
        ///</summary>
        [TestMethod()]
        public void DisconnectTest()
        {
            ScannerModels model = new ScannerModels(); // TODO: Initialize to an appropriate value
            Scanner target = new Scanner(model); // TODO: Initialize to an appropriate value
            target.Disconnect();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Connect
        ///</summary>
        [TestMethod()]
        public void ConnectTest()
        {
            ScannerModels model = new ScannerModels(); // TODO: Initialize to an appropriate value
            Scanner target = new Scanner(model); // TODO: Initialize to an appropriate value
            target.Connect();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Scanner Constructor
        ///</summary>
        [TestMethod()]
        public void ScannerConstructorTest()
        {
            ScannerModels model = new ScannerModels(); // TODO: Initialize to an appropriate value
            Scanner target = new Scanner(model);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
