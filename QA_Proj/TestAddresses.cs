using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Proj.PageObjects;
using System.Threading;

namespace QA_Proj
{
    [TestClass]
    public class TestAddresses
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
            //chromedriver.Quit();
        }

        [TestMethod]
        public void AddNewAddress()
        {
            myDataPom.AddAddressButton();
            myDataPom.FillDataAddress();
            myDataPom.SaveAddress();
            myDataPom.WaitALilBit();
            Assert.AreEqual("Alex Teo - 0747832509", myDataPom.LblAddressNamePhone.Text);
            Assert.AreEqual("Strada Soarelui nr. 12", myDataPom.LblAddressFullAddress.Text);

        }

        [TestMethod]
        public void EditAddress()
        {
            myDataPom.EditDataAddress();
            myDataPom.SaveEditedAddress();
            myDataPom.WaitALilBitMore();
            Assert.AreEqual("Dani Sergiu - 0788888888", myDataPom.LblAddressEditedNamePhone.Text);
            Assert.AreEqual("Aleea Rozelor nr. 1", myDataPom.LblAddressEditedFullAddress.Text);

        }

        [TestMethod]
        public void DeleteAddress()
        {
            if (myDataPom.CheckIfDeleteButtonExists() == true)
            {
                myDataPom.DeleteAddress();
                Assert.AreEqual("Nu ai adaugat nici o adresa pana acum. Foloseste butonul de mai jos pentru a adauga o adresa noua.", myDataPom.LblAddressDeleted.Text.Trim());

            }
            //nu am tratat cazul din cauza generarii unui data-id nou la crearea unei 
            //noi adrese pt butoanele modif si delete

            //else
            //{
            //    myDataPom.AddAddressButton();
            //    myDataPom.FillDataAddress();
            //    myDataPom.SaveAddress();
            //    myDataPom.WaitALilBit();
            //    Thread.Sleep(10000);
            //    myDataPom.DeleteAddress();
            //    Assert.AreEqual("Nu ai adaugat nici o adresa pana acum. Foloseste butonul de mai jos pentru a adauga o adresa noua.", myDataPom.LblAddressDeleted.Text.Trim());
            //}
        }
    }
}
