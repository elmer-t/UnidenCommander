using UnidenCommander.Scanner.CommandSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnidenCommander.Scanner;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for CommandSetGenericTest and is intended
    ///to contain all CommandSetGenericTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommandSetGenericTest
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
        ///A test for WriteAlphaTag
        ///</summary>
        [TestMethod()]
        public void WriteAlphaTagTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            AlphaTagType type = new AlphaTagType(); // TODO: Initialize to an appropriate value
            string bankOrChannel = string.Empty; // TODO: Initialize to an appropriate value
            string tag = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WriteAlphaTag(type, bankOrChannel, tag);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WindowVoltage
        ///</summary>
        [TestMethod()]
        public void WindowVoltageTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.WindowVoltage();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WeatherAlert
        ///</summary>
        [TestMethod()]
        public void WeatherAlertTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WeatherAlert();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WarningMuteCondition
        ///</summary>
        [TestMethod()]
        public void WarningMuteConditionTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WarningMuteCondition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WarningLightDimmer
        ///</summary>
        [TestMethod()]
        public void WarningLightDimmerTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WarningLightDimmer();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WarningLight
        ///</summary>
        [TestMethod()]
        public void WarningLightTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WarningLight();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VS
        ///</summary>
        [TestMethod()]
        public void VSTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.VS();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Version
        ///</summary>
        [TestMethod()]
        public void VersionTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Version();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for USState
        ///</summary>
        [TestMethod()]
        public void USStateTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.USState();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpperLimit
        ///</summary>
        [TestMethod()]
        public void UpperLimitTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.UpperLimit();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrunkType
        ///</summary>
        [TestMethod()]
        public void TrunkTypeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.TrunkType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrunkingControlChannelMode
        ///</summary>
        [TestMethod()]
        public void TrunkingControlChannelModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.TrunkingControlChannelMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrunkingBankMode
        ///</summary>
        [TestMethod()]
        public void TrunkingBankModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.TrunkingBankMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrunkIDMonitor
        ///</summary>
        [TestMethod()]
        public void TrunkIDMonitorTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.TrunkIDMonitor();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TalkGroupID
        ///</summary>
        [TestMethod()]
        public void TalkGroupIDTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.TalkGroupID();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SystemInformation
        ///</summary>
        [TestMethod()]
        public void SystemInformationTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            SystemInformation expected = null; // TODO: Initialize to an appropriate value
            SystemInformation actual;
            actual = target.SystemInformation();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StepSize
        ///</summary>
        [TestMethod()]
        public void StepSizeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            FrequencySteps size = new FrequencySteps(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.StepSize(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SquelchStatus
        ///</summary>
        [TestMethod()]
        public void SquelchStatusTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SquelchStatus();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SquelchNotify
        ///</summary>
        [TestMethod()]
        public void SquelchNotifyTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SquelchNotify();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SlashData
        ///</summary>
        [TestMethod()]
        public void SlashDataTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SlashData();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SignalStrength
        ///</summary>
        [TestMethod()]
        public void SignalStrengthTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            SignalStrength expected = new SignalStrength(); // TODO: Initialize to an appropriate value
            SignalStrength actual;
            actual = target.SignalStrength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ServiceScanMode
        ///</summary>
        [TestMethod()]
        public void ServiceScanModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ServiceScanMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SearchSkip
        ///</summary>
        [TestMethod()]
        public void SearchSkipTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SearchSkip();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ScanBanks
        ///</summary>
        [TestMethod()]
        public void ScanBanksTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ScanBanks();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReceiverModulation
        ///</summary>
        [TestMethod()]
        public void ReceiverModulationTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            Modulations mode = new Modulations(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReceiverModulation(mode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadAlphaTag
        ///</summary>
        [TestMethod()]
        public void ReadAlphaTagTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            AlphaTagType type = new AlphaTagType(); // TODO: Initialize to an appropriate value
            string bankOrChannel = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReadAlphaTag(type, bankOrChannel);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RadioFrequencyTune
        ///</summary>
        [TestMethod()]
        public void RadioFrequencyTuneTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.RadioFrequencyTune();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProgramMemory
        ///</summary>
        [TestMethod()]
        public void ProgramMemoryTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ProgramMemory();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PriorityScan
        ///</summary>
        [TestMethod()]
        public void PriorityScanTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PriorityScan();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PriorityNotify
        ///</summary>
        [TestMethod()]
        public void PriorityNotifyTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PriorityNotify();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PriorityID
        ///</summary>
        [TestMethod()]
        public void PriorityIDTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PriorityID();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PriorityChannel
        ///</summary>
        [TestMethod()]
        public void PriorityChannelTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.PriorityChannel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for P25Card
        ///</summary>
        [TestMethod()]
        public void P25CardTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.P25Card();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Muting
        ///</summary>
        [TestMethod()]
        public void MutingTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Muting();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Mode
        ///</summary>
        [TestMethod()]
        public void ModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Mode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Manual
        ///</summary>
        [TestMethod()]
        public void ManualTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Manual();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LowerLimit
        ///</summary>
        [TestMethod()]
        public void LowerLimitTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LowerLimit();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LockOut
        ///</summary>
        [TestMethod()]
        public void LockOutTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LockOut();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Light
        ///</summary>
        [TestMethod()]
        public void LightTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Light();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCDMask
        ///</summary>
        [TestMethod()]
        public void LCDMaskTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LCDMask();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCDLines
        ///</summary>
        [TestMethod()]
        public void LCDLinesTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.LCDLines();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCDCommands
        ///</summary>
        [TestMethod()]
        public void LCDCommandsTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string cmd = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LCDCommands(cmd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LC
        ///</summary>
        [TestMethod()]
        public void LCTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LC();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for KEY
        ///</summary>
        [TestMethod()]
        public void KEYTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string keyCode = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.KEY(keyCode);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IDScanlists
        ///</summary>
        [TestMethod()]
        public void IDScanlistsTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.IDScanlists();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IDLockoutMemory
        ///</summary>
        [TestMethod()]
        public void IDLockoutMemoryTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.IDLockoutMemory();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IDChannel
        ///</summary>
        [TestMethod()]
        public void IDChannelTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.IDChannel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ICALL
        ///</summary>
        [TestMethod()]
        public void ICALLTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ICALL();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HighwayScanMode
        ///</summary>
        [TestMethod()]
        public void HighwayScanModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.HighwayScanMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HighwayAlertSignalReceived
        ///</summary>
        [TestMethod()]
        public void HighwayAlertSignalReceivedTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.HighwayAlertSignalReceived();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HighwayAlert
        ///</summary>
        [TestMethod()]
        public void HighwayAlertTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.HighwayAlert();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLine
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void GetLineTest()
        {
            string rawLine = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CommandSetGeneric_Accessor.GetLine(rawLine);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FrequencyIdentificationMode
        ///</summary>
        [TestMethod()]
        public void FrequencyIdentificationModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FrequencyIdentificationMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FleetMapProgram
        ///</summary>
        [TestMethod()]
        public void FleetMapProgramTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FleetMapProgram();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FIPSWeatherSearchCode
        ///</summary>
        [TestMethod()]
        public void FIPSWeatherSearchCodeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FIPSWeatherSearchCode();
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
            CommandSetGeneric_Accessor target = new CommandSetGeneric_Accessor(param0); // TODO: Initialize to an appropriate value
            target.FillScannerModes();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EnterLock
        ///</summary>
        [TestMethod()]
        public void EnterLockTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.EnterLock();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EmergencyAlert
        ///</summary>
        [TestMethod()]
        public void EmergencyAlertTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.EmergencyAlert();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EDACSIDRangeMode
        ///</summary>
        [TestMethod()]
        public void EDACSIDRangeModeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.EDACSIDRangeMode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EDACS_AFS
        ///</summary>
        [TestMethod()]
        public void EDACS_AFSTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.EDACS_AFS();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DigitalVoice
        ///</summary>
        [TestMethod()]
        public void DigitalVoiceTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.DigitalVoice();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DigitalModulation
        ///</summary>
        [TestMethod()]
        public void DigitalModulationTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.DigitalModulation();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delay
        ///</summary>
        [TestMethod()]
        public void DelayTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Delay();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DataSkip
        ///</summary>
        [TestMethod()]
        public void DataSkipTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.DataSkip();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CTCSSTone
        ///</summary>
        [TestMethod()]
        public void CTCSSToneTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CTCSSTone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CTCSSSet
        ///</summary>
        [TestMethod()]
        public void CTCSSSetTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CTCSSSet();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CTCSSDetection
        ///</summary>
        [TestMethod()]
        public void CTCSSDetectionTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CTCSSDetection();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CTCSSCondition
        ///</summary>
        [TestMethod()]
        public void CTCSSConditionTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CTCSSCondition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConfirmBaseSpaceOffset
        ///</summary>
        [TestMethod()]
        public void ConfirmBaseSpaceOffsetTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ConfirmBaseSpaceOffset();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Command
        ///</summary>
        [TestMethod()]
        public void CommandTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string cmd = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Command(cmd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ChooseBanks
        ///</summary>
        [TestMethod()]
        public void ChooseBanksTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ChooseBanks();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Channel
        ///</summary>
        [TestMethod()]
        public void ChannelTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Channel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BitStatus
        ///</summary>
        [TestMethod()]
        public void BitStatusTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BitStatus();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BeepSet
        ///</summary>
        [TestMethod()]
        public void BeepSetTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BeepSet();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BeepAlert
        ///</summary>
        [TestMethod()]
        public void BeepAlertTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BeepAlert();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BatterySave
        ///</summary>
        [TestMethod()]
        public void BatterySaveTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BatterySave();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BatteryMonitorReporting
        ///</summary>
        [TestMethod()]
        public void BatteryMonitorReportingTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BatteryMonitorReporting();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BatteryLife
        ///</summary>
        [TestMethod()]
        public void BatteryLifeTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BatteryLife();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AutoRecording
        ///</summary>
        [TestMethod()]
        public void AutoRecordingTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            ScannerBoolean state = new ScannerBoolean(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AutoRecording(state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AutoLight
        ///</summary>
        [TestMethod()]
        public void AutoLightTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            ScannerBoolean state = new ScannerBoolean(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AutoLight(state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Attenuator
        ///</summary>
        [TestMethod()]
        public void AttenuatorTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            ScannerBoolean state = new ScannerBoolean(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Attenuator(state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AllClear
        ///</summary>
        [TestMethod()]
        public void AllClearTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AllClear();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ActivityIDWindow
        ///</summary>
        [TestMethod()]
        public void ActivityIDWindowTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection); // TODO: Initialize to an appropriate value
            string bank = string.Empty; // TODO: Initialize to an appropriate value
            ScannerBoolean state = new ScannerBoolean(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ActivityIDWindow(bank, state);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandSetGeneric Constructor
        ///</summary>
        [TestMethod()]
        public void CommandSetGenericConstructorTest()
        {
            Connection connection = null; // TODO: Initialize to an appropriate value
            CommandSetGeneric target = new CommandSetGeneric(connection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
