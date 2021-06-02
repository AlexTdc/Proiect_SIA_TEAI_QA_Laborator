using OpenQA.Selenium;
using System.Threading;

namespace QA_Proj.PageObjects
{
    public class LoginPOM
    {
        public IWebDriver webDriver;
        
        public LoginPOM(IWebDriver browser)
        {
            webDriver = browser;
        }

        public IWebElement TxtEmail => webDriver.FindElement(By.Id("user_login_email"));
        public IWebElement BtnEmailContinue => webDriver.FindElement(By.Id("user_login_continue"));
        public IWebElement TxtPassword => webDriver.FindElement(By.Id("user_login_password"));
        public IWebElement BtnPasswordContinue => webDriver.FindElement(By.Id("user_login_continue"));
        public IWebElement LblLoginFailed => webDriver.FindElement(By.CssSelector("body > div.auth-box.text-center > div.auth-panel > div.auth-panel-body > form > div.form-group.has-error > div > div"));

        public HomePOM LoginApplication(string email, string password)
        {
            TxtEmail.SendKeys(email);
            BtnEmailContinue.Click();
            Thread.Sleep(60000);  // SA AM TIMP SA REZOLV CAPCHA-URILE EMAG
            TxtPassword.SendKeys(password);
            BtnPasswordContinue.Click();
            Thread.Sleep(60000);  // SA AM TIMP SA REZOLV CAPCHA-URILE EMAG
            return new HomePOM(webDriver);
        }


    }
}
