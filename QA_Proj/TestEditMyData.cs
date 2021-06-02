using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Proj.PageObjects;
using System.Threading;

namespace QA_Proj
{
    [TestClass]
    public class TestEditMyData
    {
        private IWebDriver chromedriver;
        private MyDataPOM myDataPom;



        [TestInitialize]
        public void Setup()
        {
            chromedriver = new ChromeDriver();
            myDataPom = new MyDataPOM(chromedriver);
            var loginPom = new LoginPOM(chromedriver);
            var homePom = new HomePOM(chromedriver);
            var profilePom = new ProfileInfoPOM(chromedriver);
            chromedriver.Manage().Window.Maximize();
            chromedriver.Navigate().GoToUrl("https://www.emag.ro/");
            chromedriver.FindElement(By.CssSelector("#my_account > i")).Click();
            Thread.Sleep(2000);
            var homePg = loginPom.LoginApplication("testemag500@gmail.com", "TestEmag!");
            var profilePg = homePom.NavigateToProfileInfo();
            var mydataPg = profilePom.NavigateToMyData();
        }

        [TestCleanup]
        public void Cleanup()
        {
            chromedriver.Quit();
        }

        [TestMethod]
        public void EditData()
        {
            myDataPom.FillData();
            myDataPom.SaveData();
            myDataPom.CheckData();
            Assert.AreEqual("numetest", myDataPom.LblName.Text);
            Assert.AreEqual("testnick", myDataPom.LblNickname.Text);
            Assert.AreEqual("0747557084", myDataPom.LblPhone.Text);
            Assert.AreEqual("0232268907", myDataPom.LblPhoneFix.Text);
            Assert.AreEqual("17 aprilie 1998", myDataPom.LblBirthdate.Text);
            Assert.AreEqual("MBA", myDataPom.LblEducation.Text);

        }

        [TestMethod]
        public void EditDataWithInvalidPhoneNuber()
        {
            myDataPom.FillData();
            myDataPom.AddWrongPhoneNumber();
            myDataPom.SaveData();
            Thread.Sleep(5000);
            Assert.AreEqual("Te rugăm să introduci un număr de telefon valid, de forma: 07xxxxxxxx", myDataPom.LblWrongPhoneNumber.Text);
        }

        [TestMethod]
        public void EditDataWithInvalidBirthDate()
        {
            myDataPom.AddWrongBirthDate();
            myDataPom.SaveData();
            //TIMP CA SA DE VADA BUG UL (Apas salveaza si nu face nimic, dar nici nu-mi da un mesaj de eroare a datelor introduse) 
            Thread.Sleep(5000); 
            myDataPom.CheckData();
            Assert.AreEqual("30 februarie 1998", myDataPom.LblBirthdate.Text);

        }

        [TestMethod]
        public void EditNickname()
        {
            myDataPom.AddNickname();
            myDataPom.SaveData();
            myDataPom.CheckData();
            Thread.Sleep(5000);
            Assert.AreEqual("X", myDataPom.LblInitialBubble.Text);
            Assert.AreEqual("Xpertqa", myDataPom.LblInitialExtended.Text);
            //UNCOMMENT CA SA SE VADA BUG UL
            //Assert.AreEqual("X", myDataPom.LblInitialNavbar.Text);
        }

    }
}
