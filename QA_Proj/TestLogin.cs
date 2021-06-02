using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using QA_Proj.PageObjects;

namespace QA_Proj
{
    [TestClass]
    public class TestLogin
    {
        private IWebDriver chromedriver;
        private LoginPOM loginPom;

        [TestInitialize]
        public void Setup()
        {
            chromedriver = new ChromeDriver();
            loginPom = new LoginPOM(chromedriver);
            chromedriver.Manage().Window.Maximize();
            chromedriver.Navigate().GoToUrl("https://www.emag.ro/");
            chromedriver.FindElement(By.CssSelector("#my_account > i")).Click();
            Thread.Sleep(2000);

        }

        [TestCleanup]
        public void Cleanup()
        {
            chromedriver.Quit();
        }

        [TestMethod]
        public void LoginToApp()
        {
            var homePOM = loginPom.LoginApplication("testemag500@gmail.com", "TestEmag!");
            homePOM.NavigateToProfileInfo();
            var profileInfoPOM = new ProfileInfoPOM(chromedriver);
            Assert.AreEqual("testemag500@gmail.com", profileInfoPOM.LblProfileEmail.Text);

        }

        [TestMethod]
        public void FailToLoginToAppInvalidPassword()
        {
            loginPom.LoginApplication("testemag500@gmail.com", "TestEmag");
            Assert.AreEqual("Ai introdus greșit parola sau adresa de email. Te rugăm completează din nou.", loginPom.LblLoginFailed.Text);

        }
    }
}
