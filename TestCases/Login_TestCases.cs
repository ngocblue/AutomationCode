using AutomationCode.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationCode.TestCases
{
    class Login
    {
        HomePage homepage = new HomePage();
        LoginPage loginPage = new LoginPage();
        WelcomePage welcomepage = new WelcomePage();

        [SetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            Constant.Constant.WEBDRIVER = new ChromeDriver();
            Constant.Constant.WEBDRIVER.Manage().Window.Maximize();
            Constant.Constant.WEBDRIVER.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Constant.Constant.WEBDRIVER.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [Test]
        public void LoginSuccess()
        {
            /*This test case is written based on the assumption that normally user has to go to Homepage, 
             * click to 'Login' link to go to Login Page then input email/password and login */

            homepage.Open();
            homepage.goToLoginPage();

            loginPage.Login(Constant.Constant.EMAIL, Constant.Constant.PASSWORD);

            string headerText = welcomepage.GetLoginSuccessfulMessage();
            Assert.AreEqual(headerText, "You have logged-in successfully!", "Login fail");
        }

        [Test]
        public void LoginFailWithWrongEmail()
        {
            homepage.Open();
            homepage.goToLoginPage();

            loginPage.Login(Constant.Constant.INCORRECTEMAIL, Constant.Constant.PASSWORD);
            string errorMsg = loginPage.GetErrorMessage();

            Assert.AreEqual(errorMsg, "The inputted email or password is not correct.", "Error message is not as expected");
        }


        [TearDown]
        public void TearDown()
        {
            Constant.Constant.WEBDRIVER.Quit();
        }
    }
}
