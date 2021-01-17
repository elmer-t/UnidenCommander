using UnidenCommander.Scanner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Ports;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for ConnectionTest and is intended
    ///to contain all ConnectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConnectionTest
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
        ///A test for IsOpen
        ///</summary>
        [TestMethod()]
        public void IsOpenTest()
        {
            Connection target = new Connection(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOpen;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void WriteCommandTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            string command = string.Empty; // TODO: Initialize to an appropriate value
            target.WriteCommand(command);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Wait
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void WaitTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            target.Wait();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ThreadStartMethod
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ThreadStartMethodTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            object command = null; // TODO: Initialize to an appropriate value
            target.ThreadStartMethod(command);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for serialPort_DataReceived
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void serialPort_DataReceivedTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SerialDataReceivedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.serialPort_DataReceived(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ProcessBuffer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void ProcessBufferTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            string buffer = string.Empty; // TODO: Initialize to an appropriate value
            target.ProcessBuffer(buffer);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        [TestMethod()]
        public void OpenTest()
        {
            Connection target = new Connection(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Open();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            Connection target = new Connection(); // TODO: Initialize to an appropriate value
            target.Initialize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandTest()
        {
            Connection target = new Connection(); // TODO: Initialize to an appropriate value
            object command = null; // TODO: Initialize to an appropriate value
            target.ExecuteCommand(command);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for commandTimeoutCallback
        ///</summary>
        [TestMethod()]
        [DeploymentItem("UnidenCommander.exe")]
        public void commandTimeoutCallbackTest()
        {
            Connection_Accessor target = new Connection_Accessor(); // TODO: Initialize to an appropriate value
            object state = null; // TODO: Initialize to an appropriate value
            target.commandTimeoutCallback(state);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Close
        ///</summary>
        [TestMethod()]
        public void CloseTest()
        {
            Connection target = new Connection(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Close();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection Constructor
        ///</summary>
        [TestMethod()]
        public void ConnectionConstructorTest1()
        {
            Connection target = new Connection();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Connection Constructor
        ///</summary>
        [TestMethod()]
        public void ConnectionConstructorTest()
        {
            string port = string.Empty; // TODO: Initialize to an appropriate value
            int speed = 0; // TODO: Initialize to an appropriate value
            Connection target = new Connection(port, speed);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
