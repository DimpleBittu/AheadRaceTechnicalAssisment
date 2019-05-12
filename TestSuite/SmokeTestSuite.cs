using AheadRaceTechnicalTest.Common;
using AheadRaceTechnicalTest.ObjectRepository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.TestSuite
{
    class SmokeTestSuite
    {

        [SetUp]
        public void initializeSetup()
        {
            Console.WriteLine($"Initialize setup Begin");
            Console.WriteLine($"Browser Selected: {ConfigurationManager.AppSettings["executionBrowser"].ToString()}");
            CommonMethods.instantiateBrowser(ConfigurationManager.AppSettings["executionBrowser"].ToString());
            Console.WriteLine($"Initialize Setup Exit");
        }

        [Test]
        public void negVerifyLoginErrorMessage()
        {
            TC001();
        }

        [Test]
        public void requestNewPassword()
        {
            TC002();
        }

        [Test]
        public void createUserViaUpload()
        {
            TC003();
        }

        [TearDown]
        public void disposeSetup()
        {
            CommonMethods.disposeBrowser();
        }

        private void TC001()
        {
            Console.WriteLine($"TC001 Test Execution");

            //Invalid password error verification

            //Reload Application
            CommonMethods.reloadApplication();

            //verify page loaded & we are on login page.
            string verificaitonText = CommonProperties.commonDriver.FindElement(ORLoginPage.TxtVerfication).Text;
            Assert.AreEqual("User account", verificaitonText);

            //Entering Test Data
            CommonMethods.inputTxt(ConfigurationManager.AppSettings["invalidUserName"].ToString(), ORLoginPage.TxtUsername);
            CommonMethods.inputTxt(ConfigurationManager.AppSettings["invalidPassword"].ToString(), ORLoginPage.TxtPassword);

            //Click Login button
            CommonMethods.clickElement(ORLoginPage.BtnLogin);

            //waiting for page to load after login action is performed
            CommonMethods.waitUntilElementExist(ORLoginPage.ErrorInvalidUsernamePassword, 10);

            //verify invalid error message
            string verificaionErrorText = CommonProperties.commonDriver.FindElement(ORLoginPage.ErrorInvalidUsernamePassword).Text;

            //Error Message verification
            Assert.IsTrue(verificaionErrorText.Contains("Sorry, unrecognized username or password."));
            Console.WriteLine($"TC001 Execution Completed.");
        }

        private void TC002()
        {
            //Request New Password
            Console.WriteLine($"Test Case TC002");

            //Reload Application
            CommonMethods.reloadApplication();

            //Navigate to Request new Password
            CommonMethods.clickElement(ORLoginPage.LnkTabRequestNewPassword);

            //verify page loaded & we are on login page.
            string reqVerificaitonText = CommonProperties.commonDriver.FindElement(ORLoginPage.TxtReqTextVeification).Text;
            Assert.IsTrue(reqVerificaitonText.Contains("Username or e-mail address"));

            //enter email to reset password
            CommonMethods.inputTxt(ConfigurationManager.AppSettings["useEmail"].ToString(), ORLoginPage.TxtUsernameOrEmail);

            //Click login button
            CommonMethods.clickElement(ORLoginPage.BtnEmailNewPassword);

            //Success password reset message verification
            string sucessReqVerification = CommonProperties.commonDriver.FindElement(ORLoginPage.SuccessMessagePassReset).Text;

            Console.WriteLine($"{sucessReqVerification}");

            Assert.IsTrue(sucessReqVerification.Contains("Further instructions have been sent to your e-mail address."));
        }

        private void TC003()
        {
            //Reload Application
            CommonMethods.reloadApplication();

            //verify page loaded & we are on login page.
            string verificaitonText = CommonProperties.commonDriver.FindElement(ORLoginPage.TxtVerfication).Text;
            Assert.AreEqual("User account", verificaitonText);

            //Login with vaid username and password
            CommonMethods.inputTxt(ConfigurationManager.AppSettings["validUserName"].ToString(), ORLoginPage.TxtUsername);
            CommonMethods.inputTxt(ConfigurationManager.AppSettings["validPassword"].ToString(), ORLoginPage.TxtPassword);

            //Click Login button
            CommonMethods.clickElement(ORLoginPage.BtnLogin);

            //Home Page Verification
            string homeVerificationText = CommonProperties.commonDriver.FindElement(ORHomeDashboardPage.LblMyDashboard).Text;
            Assert.IsTrue(homeVerificationText.Contains("My dashboard"));

            //Navigate to People --> Users
            CommonProperties.commonDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseURL"].ToString() + ORHomeDashboardPage.MenuLnkMPeople);

            //Verify you are on People
            string peopleVerificaitonText = CommonProperties.commonDriver.FindElement(ORHomeDashboardPage.LblMyDashboard).Text;
            Assert.IsTrue(peopleVerificaitonText.Contains("People"));

            //Verify you are on Users page

            CommonProperties.commonDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseURL"].ToString() + ORHomeDashboardPage.PeopleLnkMUser);

            CommonMethods.inputTxt("TEst User", ORLoginPage.TxtUsername);


            //Navigate to Import Participants
            CommonProperties.commonDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseURL"].ToString() + ORImportParticipants.LnkImportParticipants);

            //Verify on Import Participants page
            string importpartVerificaitonText = CommonProperties.commonDriver.FindElement(ORLoginPage.TxtVerfication).Text;

            Assert.IsTrue(importpartVerificaitonText.Contains("Import Participants"));

            //Select Delemiter value
            CommonMethods.selectElement(",", ORImportParticipants.drpDownDelimiter);

            //Upload csv file and click open
            CommonMethods.clickElement(ORImportParticipants.BTNBrowse);

            CommonMethods.inputTxt("Test", ORImportParticipants.BTNBrowse);

            //Click import

            //Assert user1 created
        }
    }
}
