using OpenQA.Selenium;

namespace QA_Proj.PageObjects
{
    public class ProfileInfoPOM
    {
        private IWebDriver driver;

        public ProfileInfoPOM(IWebDriver browser)
        {
            driver = browser;
        }

        private By Email = By.CssSelector("#main-container > section > div > div.page-container > section > div > div.col-md-8.personal_data-slot.user-dashboard-slot > div > div.panel-body > div > div.col-sm-4.col-md-8.col-lg-6.user-data-col > div.hidden-xs.pad-rgt-xxs > p:nth-child(3) > span.field-value");
        public IWebElement LblProfileEmail => driver.FindElement(Email);

        private By MyData = By.CssSelector("#main-container > section > div > div.page-container > section > div > div.col-md-8.personal_data-slot.user-dashboard-slot > div > div.panel-footer > a");
        public IWebElement BtnGoToMyData => driver.FindElement(MyData);

        public MyDataPOM NavigateToMyData()
        {
            BtnGoToMyData.Click();
            return new MyDataPOM(driver);
        }

    }
}
