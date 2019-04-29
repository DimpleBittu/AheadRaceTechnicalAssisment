using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace AheadRaceTechnicalTest.Core
{
    class ReadXMLData
    {
        public static string setXMLValues()
        {
            string returnValue = "EmptyVarible";

            using (XmlReader objXMLReader = XmlReader.Create(Common.CommonProperties.strXMLFilePath))
            {
                while (objXMLReader.Read())
                {
                    if (objXMLReader.IsStartElement())
                    {
                        switch (objXMLReader.Name.ToString())
                        {
                            case "UserName":
                                {
                                    Console.WriteLine($"username from XML file: {objXMLReader.ReadString()}");
                                    returnValue=objXMLReader.ReadString();
                                    break;
                                }
                            case "Password":
                                {
                                    Console.WriteLine($"password from XML file: {objXMLReader.ReadString()}");
                                    returnValue = objXMLReader.ReadString();
                                    break;
                                }
                            case "IncorrectUserName":
                                {
                                    Console.WriteLine($"Invalid username from XML file: {objXMLReader.ReadString()}");
                                    returnValue = objXMLReader.ReadString();
                                    break;
                                }
                            case "IncorrectPassword":
                                {
                                    Console.WriteLine($"Invalid password from XML file: {objXMLReader.ReadString()}");
                                    returnValue = objXMLReader.ReadString();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine($"Invalid Parameter...");
                                    break;
                                }
                        }
                    }
                }
            }
            return returnValue;
        }
    }
}
