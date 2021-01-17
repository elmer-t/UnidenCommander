using UnidenCommander;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for S_MeterTest and is intended
    ///to contain all S_MeterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class S_MeterTest
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
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S6
        ///</summary>
        [TestMethod()]
        public void S6Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S6 = expected;
            actual = target.S6;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S5
        ///</summary>
        [TestMethod()]
        public void S5Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S5 = expected;
            actual = target.S5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S4
        ///</summary>
        [TestMethod()]
        public void S4Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S4 = expected;
            actual = target.S4;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S3
        ///</summary>
        [TestMethod()]
        public void S3Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S3 = expected;
            actual = target.S3;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S2
        ///</summary>
        [TestMethod()]
        public void S2Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S2 = expected;
            actual = target.S2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S1
        ///</summary>
        [TestMethod()]
        public void S1Test()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            Panel expected = null; // TODO: Initialize to an appropriate value
            Panel actual;
            target.S1 = expected;
            actual = target.S1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Minimum
        ///</summary>
        [TestMethod()]
        public void MinimumTest()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Minimum = expected;
            actual = target.Minimum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Maximum
        ///</summary>
        [TestMethod()]
        public void MaximumTest()
        {
            S_Meter target = new S_Meter(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Maximum = expected;
            actual = target.Maximum;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for S_Meter_Paint
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void S_Meter_PaintTest()
        {
            S_Meter_Accessor target = new S_Meter_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            PaintEventArgs e = null; // TODO: Initialize to an appropriate value
            target.S_Meter_Paint(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeComponentTest()
        {
            S_Meter_Accessor target = new S_Meter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void DisposeTest()
        {
            S_Meter_Accessor target = new S_Meter_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for S_Meter Constructor
        ///</summary>
        [TestMethod()]
        public void S_MeterConstructorTest()
        {
            S_Meter target = new S_Meter();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
