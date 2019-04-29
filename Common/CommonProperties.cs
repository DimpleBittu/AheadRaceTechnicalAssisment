using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.Common
{
    class CommonProperties
    {
        public static string baseURL = "https://ondemand.questionmark.com/home/403160/";
        public static string executionBrowser = "Chrome";
        public static IWebDriver commonDriver;
        public static string strXMLFilePath = @"..\TestData\XMLTestConfigurations.xml";
        public static string strGlobalusername, strGlobalPassword;
    }
}
