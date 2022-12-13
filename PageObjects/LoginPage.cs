using OpenQA.Selenium;

namespace AutomationFramework.PageObjects
{
    class LoginPage : GeneralPage
    {
        private By emailTextbox = By.Id("txtEmail");
        private By passwordTextbox = By.Id("txtPassword");
        private By loginButton = By.Id("btnLogin");
        private By errorMsg = By.Id("lblPasswordErr");

        protected IWebElement getemailTextbox() => Constant.Constant.WEBDRIVER.FindElement(emailTextbox);
        protected IWebElement getPasswordTextbox() => Constant.Constant.WEBDRIVER.FindElement(passwordTextbox);
        protected IWebElement getLoginButton() => Constant.Constant.WEBDRIVER.FindElement(loginButton);
        protected IWebElement getErrorMsg() => Constant.Constant.WEBDRIVER.FindElement(errorMsg);
        public void Login(string username, string password)
        {
            this.getemailTextbox().SendKeys(username);
            this.getPasswordTextbox().SendKeys(password);
            this.getLoginButton().Click();
        }

        public string GetErrorMessage()
        {
            return this.getErrorMsg().Text;
        }

    }
}
