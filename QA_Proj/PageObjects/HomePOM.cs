using OpenQA.Selenium;

namespace QA_Proj.PageObjects
{
    public class HomePOM
    {
        private IWebDriver driver;

        public HomePOM(IWebDriver browser)
        {
            driver = browser;
        }

        private By ProfileTE = By.CssSelector("#my_account > div > div > div > span");
        public IWebElement BtnProfileTE => driver.FindElement(ProfileTE);

        public ProfileInfoPOM NavigateToProfileInfo()
        {
            BtnProfileTE.Click();
            return new ProfileInfoPOM(driver);
        }
    }
}
