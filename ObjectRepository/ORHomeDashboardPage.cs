using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.ObjectRepository
{
    class ORHomeDashboardPage
    {
        //People Menu with Sub Menu values
        public static string MenuLnkMPeople = "people";
        public static string PeopleLnkMUser = "admin/people";
        
        //public static By SubMRole = By.XPath("//*[@href='/home/403160/admin/people/permissions/roles']");
        //public static By SubMPassPolicy = By.XPath("//*[@href='/home/403160/admin/config/people/password_policy/list']");
        //public static By SubMUnblockUser = By.XPath("//*[@href='/home/403160/admin/config/people/flood_unblock']");
        //public static By SubMGroup = By.XPath("//*[@href='/home/403160/people/groups']");
        //public static By SubMConfigureOptionalEmail = By.XPath("//*[@href='/home/403160/people/optional_mail']");

        //Home Dashboard Verification Element
        public static By LblMyDashboard = By.XPath("//h1[@class='page-header']");


        //People --> User Page Verification Element
        public static By LblUser = By.XPath("//h1[@class='page-header']");
    }
}
