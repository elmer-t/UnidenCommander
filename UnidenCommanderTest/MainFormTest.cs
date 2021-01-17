using UnidenCommander;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnidenCommander.Scanner;
using System.Windows.Forms;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for MainFormTest and is intended
    ///to contain all MainFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainFormTest
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
        ///A test for txtCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void txtCommandTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            TextBox expected = null; // TODO: Initialize to an appropriate value
            TextBox actual;
            target.txtCommand = expected;
            actual = target.txtCommand;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for toolStripMenuItem2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void toolStripMenuItem2Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripSeparator expected = null; // TODO: Initialize to an appropriate value
            ToolStripSeparator actual;
            target.toolStripMenuItem2 = expected;
            actual = target.toolStripMenuItem2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for statusStrip1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void statusStrip1Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            StatusStrip expected = null; // TODO: Initialize to an appropriate value
            StatusStrip actual;
            target.statusStrip1 = expected;
            actual = target.statusStrip1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Status
        ///</summary>
        [TestMethod()]
        public void StatusTest()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.Status = expected;
            actual = target.Status;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for settingsToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void settingsToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.settingsToolStripMenuItem = expected;
            actual = target.settingsToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScreenRefreshTimer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ScreenRefreshTimerTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Timer expected = null; // TODO: Initialize to an appropriate value
            Timer actual;
            target.ScreenRefreshTimer = expected;
            actual = target.ScreenRefreshTimer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for scannerInfoToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void scannerInfoToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.scannerInfoToolStripMenuItem = expected;
            actual = target.scannerInfoToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScannerInfo
        ///</summary>
        [TestMethod()]
        public void ScannerInfoTest()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.ScannerInfo = expected;
            actual = target.ScannerInfo;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Port
        ///</summary>
        [TestMethod()]
        public void PortTest()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.Port = expected;
            actual = target.Port;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for pictureBox1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void pictureBox1Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            PictureBox expected = null; // TODO: Initialize to an appropriate value
            PictureBox actual;
            target.pictureBox1 = expected;
            actual = target.pictureBox1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for menuStrip1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void menuStrip1Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            MenuStrip expected = null; // TODO: Initialize to an appropriate value
            MenuStrip actual;
            target.menuStrip1 = expected;
            actual = target.menuStrip1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lblStatus
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lblStatusTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.lblStatus = expected;
            actual = target.lblStatus;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lblSpeed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lblSpeedTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.lblSpeed = expected;
            actual = target.lblSpeed;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lblScannerInfo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lblScannerInfoTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.lblScannerInfo = expected;
            actual = target.lblScannerInfo;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lblPort
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void lblPortTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.lblPort = expected;
            actual = target.lblPort;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for helpToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void helpToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.helpToolStripMenuItem = expected;
            actual = target.helpToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for firstRunTimer
        ///</summary>
        [TestMethod()]
        public void firstRunTimerTest()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            Timer expected = null; // TODO: Initialize to an appropriate value
            Timer actual;
            target.firstRunTimer = expected;
            actual = target.firstRunTimer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for fileToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void fileToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.fileToolStripMenuItem = expected;
            actual = target.fileToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for exitToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void exitToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.exitToolStripMenuItem = expected;
            actual = target.exitToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Display1
        ///</summary>
        [TestMethod()]
        public void Display1Test()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            Display expected = null; // TODO: Initialize to an appropriate value
            Display actual;
            target.Display1 = expected;
            actual = target.Display1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnTransfer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnTransferTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnTransfer = expected;
            actual = target.btnTransfer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStepAuto
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStepAutoTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStepAuto = expected;
            actual = target.btnStepAuto;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep7_5k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep7_5kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep7_5k = expected;
            actual = target.btnStep7_5k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep5k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep5kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep5k = expected;
            actual = target.btnStep5k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep50k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep50kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep50k = expected;
            actual = target.btnStep50k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep25k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep25kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep25k = expected;
            actual = target.btnStep25k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep12_5k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep12_5kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep12_5k = expected;
            actual = target.btnStep12_5k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep10k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep10kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep10k = expected;
            actual = target.btnStep10k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnStep100k
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep100kTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnStep100k = expected;
            actual = target.btnStep100k;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnSrch
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnSrchTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnSrch = expected;
            actual = target.btnSrch;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnScan
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnScanTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnScan = expected;
            actual = target.btnScan;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnRvrs
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRvrsTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnRvrs = expected;
            actual = target.btnRvrs;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnRsm
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRsmTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnRsm = expected;
            actual = target.btnRsm;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnRotaryUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotaryUpTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnRotaryUp = expected;
            actual = target.btnRotaryUp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnRotarySelect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotarySelectTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnRotarySelect = expected;
            actual = target.btnRotarySelect;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnRotaryDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotaryDownTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnRotaryDown = expected;
            actual = target.btnRotaryDown;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnPriority
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnPriorityTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnPriority = expected;
            actual = target.btnPriority;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnPeriod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnPeriodTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnPeriod = expected;
            actual = target.btnPeriod;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnMute
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnMuteTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnMute = expected;
            actual = target.btnMute;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnModeWFM
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeWFMTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnModeWFM = expected;
            actual = target.btnModeWFM;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnModeNFM
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeNFMTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnModeNFM = expected;
            actual = target.btnModeNFM;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnModeFM
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeFMTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnModeFM = expected;
            actual = target.btnModeFM;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnModeAuto
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeAutoTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnModeAuto = expected;
            actual = target.btnModeAuto;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnModeAM
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeAMTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnModeAM = expected;
            actual = target.btnModeAM;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnMenu
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnMenuTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnMenu = expected;
            actual = target.btnMenu;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnManual
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnManualTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnManual = expected;
            actual = target.btnManual;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnLockOut
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnLockOutTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnLockOut = expected;
            actual = target.btnLockOut;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnLimit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnLimitTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnLimit = expected;
            actual = target.btnLimit;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnHold
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnHoldTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnHold = expected;
            actual = target.btnHold;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnEnter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnEnterTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnEnter = expected;
            actual = target.btnEnter;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnCommandTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnCommand = expected;
            actual = target.btnCommand;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnATT
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnATTTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnATT = expected;
            actual = target.btnATT;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btnAir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnAirTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btnAir = expected;
            actual = target.btnAir;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn9
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn9Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn9 = expected;
            actual = target.btn9;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn8
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn8Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn8 = expected;
            actual = target.btn8;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn7
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn7Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn7 = expected;
            actual = target.btn7;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn6
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn6Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn6 = expected;
            actual = target.btn6;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn5
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn5Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn5 = expected;
            actual = target.btn5;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn4
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn4Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn4 = expected;
            actual = target.btn4;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn3
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn3Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn3 = expected;
            actual = target.btn3;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn2Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn2 = expected;
            actual = target.btn2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn1Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn1 = expected;
            actual = target.btn1;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn0
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn0Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Button expected = null; // TODO: Initialize to an appropriate value
            Button actual;
            target.btn0 = expected;
            actual = target.btn0;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BaudRate
        ///</summary>
        [TestMethod()]
        public void BaudRateTest()
        {
            MainForm target = new MainForm(); // TODO: Initialize to an appropriate value
            ToolStripStatusLabel expected = null; // TODO: Initialize to an appropriate value
            ToolStripStatusLabel actual;
            target.BaudRate = expected;
            actual = target.BaudRate;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for aboutToolStripMenuItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void aboutToolStripMenuItemTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            ToolStripMenuItem expected = null; // TODO: Initialize to an appropriate value
            ToolStripMenuItem actual;
            target.aboutToolStripMenuItem = expected;
            actual = target.aboutToolStripMenuItem;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for settingsToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void settingsToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.settingsToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetButtonState
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void SetButtonStateTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            bool enabled = false; // TODO: Initialize to an appropriate value
            target.SetButtonState(enabled);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ScreenRefreshTimer_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ScreenRefreshTimer_TickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ScreenRefreshTimer_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ScannerState2Screen
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ScannerState2ScreenTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            target.ScannerState2Screen();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for scannerInfoToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void scannerInfoToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.scannerInfoToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ResponseReceived
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ResponseReceivedTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            string response = string.Empty; // TODO: Initialize to an appropriate value
            target.ResponseReceived(response);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PressKey
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void PressKeyTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            string keyCode = string.Empty; // TODO: Initialize to an appropriate value
            target.PressKey(keyCode);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainForm_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void MainForm_LoadTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.MainForm_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeScreen
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeScreenTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeScreen();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeScanner
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeScannerTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeScanner();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void InitializeComponentTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for firstRunTimer_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void firstRunTimer_TickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.firstRunTimer_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for exitToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void exitToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.exitToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void DisposeTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayException
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void DisplayExceptionTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            Exception ex = null; // TODO: Initialize to an appropriate value
            target.DisplayException(ex);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConnectionTimeoutEventHandler
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ConnectionTimeoutEventHandlerTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            CommandTimeoutEventArgs e = null; // TODO: Initialize to an appropriate value
            target.ConnectionTimeoutEventHandler(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CommandExecuted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void CommandExecutedTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            string command = string.Empty; // TODO: Initialize to an appropriate value
            target.CommandExecuted(command);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnTransfer_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnTransfer_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnTransfer_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnToggleCommandLogging_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnToggleCommandLogging_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnToggleCommandLogging_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStepAuto_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStepAuto_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStepAuto_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep7_5k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep7_5k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep7_5k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep5k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep5k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep5k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep50k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep50k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep50k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep25k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep25k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep25k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep12_5k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep12_5k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep12_5k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep10k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep10k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep10k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnStep100k_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnStep100k_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnStep100k_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSrch_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnSrch_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSrch_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnScan_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnScan_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnScan_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSaveBanks_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnSaveBanks_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSaveBanks_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRvrs_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRvrs_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRvrs_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRsm_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRsm_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRsm_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRotaryUp_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotaryUp_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRotaryUp_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRotarySelect_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotarySelect_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRotarySelect_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRotaryDown_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnRotaryDown_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRotaryDown_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnReadBanks_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnReadBanks_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnReadBanks_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnPriority_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnPriority_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnPriority_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnPeriod_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnPeriod_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnPeriod_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnMute_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnMute_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnMute_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnModeWFM_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeWFM_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnModeWFM_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnModeNFM_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeNFM_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnModeNFM_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnModeFM_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeFM_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnModeFM_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnModeAuto_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeAuto_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnModeAuto_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnModeAM_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnModeAM_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnModeAM_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnMenu_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnMenu_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnMenu_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnManual_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnManual_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnManual_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnLockOut_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnLockOut_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnLockOut_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnLimit_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnLimit_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnLimit_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnHold_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnHold_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnHold_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnEnter_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnEnter_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnEnter_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCommand_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnCommand_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCommand_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnATT_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnATT_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnATT_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnAir_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btnAir_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnAir_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn9_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn9_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn9_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn8_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn8_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn8_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn7_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn7_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn7_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn6_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn6_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn6_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn5_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn5_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn5_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn4_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn4_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn4_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn3_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn3_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn3_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn2_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn2_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn1_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn1_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btn0_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void btn0_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btn0_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for aboutToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void aboutToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.aboutToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MainForm Constructor
        ///</summary>
        [TestMethod()]
        public void MainFormConstructorTest()
        {
            MainForm target = new MainForm();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
