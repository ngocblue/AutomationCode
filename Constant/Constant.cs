using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCode.Constant
{
    class Constant
    {
        public static IWebDriver WEBDRIVER;
        public static string APP_URL = "https://demoqa.com/books";
        public static string EMAIL = "vuthibichngoc1989@gmail.com";
        public static string INCORRECTEMAIL = "nonExistEmail@gmail.com";
        public static string PASSWORD = "Password@123";
    }
}
