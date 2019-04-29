using AheadRaceTechnicalTest.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.TestSuite
{
    class SmokeTestSuite
    {

        [SetUp]
        public void initializeSetup()
        {
            CommonMethods.instantiateBrowser(CommonProperties.executionBrowser);
        }

        [Test]
        public void negVerifyLoginErrorMessage()
        {
            TC001();
        }

        [TearDown]
        public void disposeSetup()
        {
            CommonMethods.disposeBrowser();
        }

        private void TC001()
        {
            CommonMethods.reloadApplication();
            //verify page loaded & we are on login page.
            Assert.AreEqual("expected", "actual");

            CommonMethods.inputTxt(CommonProperties)

        }
    }
}
