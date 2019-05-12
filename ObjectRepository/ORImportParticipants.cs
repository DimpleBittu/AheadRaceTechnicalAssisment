using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AheadRaceTechnicalTest.ObjectRepository
{
    class ORImportParticipants
    {
        public static string LnkImportParticipants = "admin/people/import-participants";
        public static By drpDownDelimiter = By.Id("edit-feeds-feedscsvparser-delimiter");
        public static By BTNBrowse = By.Id("edit-feeds-feedsfilefetcher-upload");
    }
}
