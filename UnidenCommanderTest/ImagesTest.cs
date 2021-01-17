using UnidenCommander.My.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace UnidenCommanderTest
{
    
    
    /// <summary>
    ///This is a test class for ImagesTest and is intended
    ///to contain all ImagesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImagesTest
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
        ///A test for UC
        ///</summary>
        [TestMethod()]
        public void UCTest()
        {
            Icon actual;
            actual = Images.UC;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResourceManager
        ///</summary>
        [TestMethod()]
        public void ResourceManagerTest()
        {
            ResourceManager actual;
            actual = Images.ResourceManager;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for logo_small
        ///</summary>
        [TestMethod()]
        public void logo_smallTest()
        {
            Bitmap actual;
            actual = Images.logo_small;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for logo_large
        ///</summary>
        [TestMethod()]
        public void logo_largeTest()
        {
            Bitmap actual;
            actual = Images.logo_large;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Culture
        ///</summary>
        [TestMethod()]
        public void CultureTest()
        {
            CultureInfo expected = null; // TODO: Initialize to an appropriate value
            CultureInfo actual;
            Images.Culture = expected;
            actual = Images.Culture;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for button_light
        ///</summary>
        [TestMethod()]
        public void button_lightTest()
        {
            Bitmap actual;
            actual = Images.button_light;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for button_dark
        ///</summary>
        [TestMethod()]
        public void button_darkTest()
        {
            Bitmap actual;
            actual = Images.button_dark;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Images Constructor
        ///</summary>
        [TestMethod()]
        public void ImagesConstructorTest()
        {
            Images target = new Images();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
