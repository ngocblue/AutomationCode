using OpenQA.Selenium;

namespace AutomationFramework.PageObjects
{
    class GeneralPage
    {
        private By loginLink = By.Id("login");
        protected IWebElement getloginLink() => Constant.Constant.WEBDRIVER.FindElement(loginLink);

        public void goToLoginPage()
        {
            this.getloginLink().Click();
        }
    }
}