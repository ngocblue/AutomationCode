using OpenQA.Selenium;

namespace AutomationCode.PageObjects
{
    class WelcomePage : GeneralPage
    {
        private By loginSuccessMsg = By.Id("lblLoggedinSuccessfully");

        protected IWebElement getLoginSuccessMsg() => Constant.Constant.WEBDRIVER.FindElement(loginSuccessMsg);

        public string GetLoginSuccessfulMessage()
        {
            return this.getLoginSuccessMsg().Text;
        }
    }
}
