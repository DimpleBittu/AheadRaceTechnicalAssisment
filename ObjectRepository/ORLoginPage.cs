using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.ObjectRepository
{
    class ORLoginPage
    {
        #region LoginTab
        public static By LnkTabLogin = By.LinkText("Log in");
        public static By TxtUsername = By.Id("edit-name");
        public static By TxtPassword = By.Id("edit-pass");
        public static By BtnLogin = By.Id("edit-submit");
        public static By TxtVerfication = By.XPath("//h1[contains(text(),'User account')]");

        public static By ErrorInvalidUsernamePassword = By.XPath("//*[@class='alert alert-block alert-danger']");
        #endregion

        #region Password Reset Tab
        public static By LnkTabRequestNewPassword = By.LinkText("Request new password");
        public static By TxtUsernameOrEmail = By.Id("edit-name");
        public static By BtnEmailNewPassword = By.Id("edit-submit");

        public static By TxtReqTextVeification = By.XPath("//*[@for='edit-name']");

        public static By SuccessMessagePassReset = By.XPath("//*[@class='alert alert-block alert-success']");
        #endregion
    }
}
