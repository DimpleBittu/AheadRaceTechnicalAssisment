using AheadRaceTechnicalTest.Core;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.Common
{
    class CommonMethods
    {
        /// <summary>
        /// Reload application can avoid Sync problems faced between the test cases.
        /// </summary>
        public static void reloadApplication()
        {
            ReadXMLData.setXMLValues();
            CommonProperties.commonDriver.Navigate().Refresh();
            CommonProperties.commonDriver.Navigate().GoToUrl(CommonProperties.baseURL);
        }

        /// <summary>
        /// Browser Selection via Common Properties file, based on the browser common driver will be initialted
        /// </summary>
        /// <param name="BrowserName"></param>
        public static void instantiateBrowser(string BrowserName)
        {
            switch (CommonProperties.executionBrowser)
            {
                //Case for Chrome Browser
                case "chrome":
                    {
                        CommonProperties.commonDriver = new ChromeDriver();
                        CommonProperties.commonDriver.Manage().Window.Maximize();
                        break;
                    }
                default:
                    {
                        CommonProperties.commonDriver = new ChromeDriver();
                        CommonProperties.commonDriver.Manage().Window.Maximize();
                        break;
                    }
            }

        }

        /// <summary>
        /// Disposing initialized broser after test execution.
        /// </summary>
        public static void disposeBrowser()
        {
            CommonProperties.commonDriver.Close();
            CommonProperties.commonDriver.Quit();
        }

        /// <summary>
        /// Common method for text field only, where it clears field & then enters values
        /// </summary>
        /// <param name="TextToInput">Text to be entered into the field.</param>
        /// <param name="Locator">Element to perform action on.</param>
        public static void inputTxt(string TextToInput, OpenQA.Selenium.By Locator)
        {
            var currTxtElement = CommonProperties.commonDriver.FindElement(Locator);
            //clear garbage value
            currTxtElement.Clear();
            currTxtElement.SendKeys(TextToInput);
        }

        /// <summary>
        /// Common method for click functionality.
        /// </summary>
        /// <param name="Locator">Element to perform action on.</param>
        public static void clickElement(OpenQA.Selenium.By Locator)
        {
            CommonProperties.commonDriver.FindElement(Locator).Click();
        }
    }
}
