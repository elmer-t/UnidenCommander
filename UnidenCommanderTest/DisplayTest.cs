using UnidenCommander;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for DisplayTest and is intended
    ///to contain all DisplayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DisplayTest
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
        ///A test for WindowVoltage
        ///</summary>
        [TestMethod()]
        public void WindowVoltageTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            target.WindowVoltage = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for txtLine4
        ///</summary>
        [TestMethod()]
        public void txtLine4Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.txtLine4 = expected;
            actual = target.txtLine4;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for txtLine3
        ///</summary>
        [TestMethod()]
        public void txtLine3Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.txtLine3 = expected;
            actual = target.txtLine3;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for txtLine2
        ///</summary>
        [TestMethod()]
        public void txtLine2Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.txtLine2 = expected;
            actual = target.txtLine2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for txtLine1
        ///</summary>
        [TestMethod()]
        public void txtLine1Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.txtLine1 = expected;
            actual = target.txtLine1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for txtCenter
        ///</summary>
        [TestMethod()]
        public void txtCenterTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.txtCenter = expected;
            actual = target.txtCenter;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SignalStrength
        ///</summary>
        [TestMethod()]
        public void SignalStrengthTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            target.SignalStrength = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for S_Meter1
        ///</summary>
        [TestMethod()]
        public void S_Meter1Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            S_Meter expected = null; // TODO: Initialize to an appropriate value
            S_Meter actual;
            target.S_Meter1 = expected;
            actual = target.S_Meter1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Priority
        ///</summary>
        [TestMethod()]
        public void PriorityTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            target.Priority = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Mute
        ///</summary>
        [TestMethod()]
        public void MuteTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            target.Mute = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Modulation
        ///</summary>
        [TestMethod()]
        public void ModulationTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Modulation = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Mode
        ///</summary>
        [TestMethod()]
        public void ModeTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Mode = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Lines
        ///</summary>
        [TestMethod()]
        public void LinesTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.Lines = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Line4
        ///</summary>
        [TestMethod()]
        public void Line4Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Line4 = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Line3
        ///</summary>
        [TestMethod()]
        public void Line3Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Line3 = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Line2
        ///</summary>
        [TestMethod()]
        public void Line2Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Line2 = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Line1
        ///</summary>
        [TestMethod()]
        public void Line1Test()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Line1 = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Frequency
        ///</summary>
        [TestMethod()]
        public void FrequencyTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            target.Frequency = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Direction
        ///</summary>
        [TestMethod()]
        public void DirectionTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            Display.ScanDirections expected = new Display.ScanDirections(); // TODO: Initialize to an appropriate value
            target.Direction = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Channel
        ///</summary>
        [TestMethod()]
        public void ChannelTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            target.Channel = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for Att
        ///</summary>
        [TestMethod()]
        public void AttTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            target.Att = expected;
            Assert.Inconclusive("Write-only properties cannot be verified.");
        }

        /// <summary>
        ///A test for SetLine2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void SetLine2Test()
        {
            Display_Accessor target = new Display_Accessor(); // TODO: Initialize to an appropriate value
            target.SetLine2();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetLine1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void SetLine1Test()
        {
            Display_Accessor target = new Display_Accessor(); // TODO: Initialize to an appropriate value
            target.SetLine1();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            Display target = new Display(); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeComponentTest()
        {
            Display_Accessor target = new Display_Accessor(); // TODO: Initialize to an appropriate value
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
            Display_Accessor target = new Display_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Display Constructor
        ///</summary>
        [TestMethod()]
        public void DisplayConstructorTest()
        {
            Display target = new Display();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
