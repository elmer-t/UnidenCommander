using UnidenCommander;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for SettingsFormTest and is intended
    ///to contain all SettingsFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SettingsFormTest
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
        ///A test for radWait50
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radWait50Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radWait50 = expected;
            actual = target.radWait50;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radWait5
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radWait5Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radWait5 = expected;
            actual = target.radWait5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radWait15
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radWait15Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radWait15 = expected;
            actual = target.radWait15;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radWait1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radWait1Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radWait1 = expected;
            actual = target.radWait1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radTimeout5
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radTimeout5Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radTimeout5 = expected;
            actual = target.radTimeout5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radTimeout2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radTimeout2Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radTimeout2 = expected;
            actual = target.radTimeout2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radTimeout10
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radTimeout10Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radTimeout10 = expected;
            actual = target.radTimeout10;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radTimeout1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radTimeout1Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radTimeout1 = expected;
            actual = target.radTimeout1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radRefresh2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radRefresh2Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radRefresh2 = expected;
            actual = target.radRefresh2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radRefresh1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radRefresh1Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radRefresh1 = expected;
            actual = target.radRefresh1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radRefresh0_5
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radRefresh0_5Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radRefresh0_5 = expected;
            actual = target.radRefresh0_5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for radRefresh0_25
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void radRefresh0_25Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            RadioButton expected = null; // TODO: Initialize to an appropriate value
            RadioButton actual;
            target.radRefresh0_25 = expected;
            actual = target.radRefresh0_25;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lstSpeeds
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lstSpeedsTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            ComboBox expected = null; // TODO: Initialize to an appropriate value
            ComboBox actual;
            target.lstSpeeds = expected;
            actual = target.lstSpeeds;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lstPorts
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lstPortsTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            ComboBox expected = null; // TODO: Initialize to an appropriate value
            ComboBox actual;
            target.lstPorts = expected;
            actual = target.lstPorts;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for label5
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void label5Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.label5 = expected;
            actual = target.label5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for label4
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void label4Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.label4 = expected;
            actual = target.label4;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for label3
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void label3Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.label3 = expected;
            actual = target.label3;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for label2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void label2Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.label2 = expected;
            actual = target.label2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for label1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void label1Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Label expected = null; // TODO: Initialize to an appropriate value
            Label actual;
            target.label1 = expected;
            actual = target.label1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for grpWait
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void grpWaitTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            GroupBox expected = null; // TODO: Initialize to an appropriate value
            GroupBox actual;
            target.grpWait = expected;
            actual = target.grpWait;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for grpTimeout
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void grpTimeoutTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            GroupBox expected = null; // TODO: Initialize to an appropriate value
            GroupBox actual;
            target.grpTimeout = expected;
            actual = target.grpTimeout;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for grpScreenRefresh
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void grpScreenRefreshTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            GroupBox expected = null; // TODO: Initialize to an appropriate value
            GroupBox actual;
            target.grpScreenRefresh = expected;
            actual = target.grpScreenRefresh;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for groupBox1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void groupBox1Test()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            GroupBox expected = null; // TODO: Initialize to an appropriate value
            GroupBox actual;
            target.groupBox1 = expected;
            actual = target.groupBox1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnSave
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnSaveTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnSave = expected;
            actual = target.btnSave;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnCancel
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnCancelTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnCancel = expected;
            actual = target.btnCancel;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SettingsForm_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void SettingsForm_LoadTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.SettingsForm_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeComponentTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetRadioButtonTag
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void GetRadioButtonTagTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            GroupBox grp = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetRadioButtonTag(grp);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void DisposeTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSave_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnSave_ClickTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSave_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnCancel_ClickTest()
        {
            SettingsForm_Accessor target = new SettingsForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SettingsForm Constructor
        ///</summary>
        [TestMethod()]
        public void SettingsFormConstructorTest()
        {
            SettingsForm target = new SettingsForm();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
