using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace QA_Proj.PageObjects
{
    public class MyDataPOM
    {
        private IWebDriver driver;

        public MyDataPOM(IWebDriver browser)
        {
            driver = browser;
        }

        //Pentru Editarea Datelor Personale
        private By Gender = By.CssSelector("input[type=\"radio\" i]");
        public IList<IWebElement> LstGender => driver.FindElements(Gender);

        private By Name = By.CssSelector("#detailsForm > fieldset > div:nth-child(2) > div > input");
        public IWebElement TxtName => driver.FindElement(Name);

        private By Nickname = By.CssSelector("#detailsForm > fieldset > div:nth-child(3) > div > input");
        public IWebElement TxtNickname => driver.FindElement(Nickname);

        private By Phone = By.CssSelector("#mobilphone");
        public IWebElement TxtPhone => driver.FindElement(Phone);

        private By PhoneFix = By.CssSelector("#detailsForm > fieldset > div:nth-child(5) > div > input");
        public IWebElement TxtPhoneFix => driver.FindElement(PhoneFix);

        private By Day = By.CssSelector("#detailsForm > fieldset > div:nth-child(6) > div > div:nth-child(2) > select > option");
        public IList<IWebElement> LstDay => driver.FindElements(Day);

        private By Month = By.CssSelector("#detailsForm > fieldset > div:nth-child(6) > div > div:nth-child(3) > select > option");
        public IList<IWebElement> LstMonth => driver.FindElements(Month);

        private By Year = By.CssSelector("#detailsForm > fieldset > div:nth-child(6) > div > div:nth-child(4) > select > option");
        public IList<IWebElement> LstYear => driver.FindElements(Year);

        private By Education = By.CssSelector("#nivel_educatie > option");
        public IList<IWebElement> LstEducation => driver.FindElements(Education);

        private By Save = By.CssSelector("#detailsForm > button");
        public IWebElement BtnSave => driver.FindElement(Save);

        private By NameLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(1) > div > span");
        public IWebElement LblName => driver.FindElement(NameLbl);

        private By NicknameLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(2) > div > span");
        public IWebElement LblNickname => driver.FindElement(NicknameLbl);

        private By PhoneLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(3) > div > span");
        public IWebElement LblPhone => driver.FindElement(PhoneLbl);

        private By PhoneFixLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(4) > div > span");
        public IWebElement LblPhoneFix => driver.FindElement(PhoneFixLbl);

        private By BirthdateLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(5) > div > span");
        public IWebElement LblBirthdate => driver.FindElement(BirthdateLbl);

        private By EducationLbl = By.CssSelector("#detailsForm > fieldset > div:nth-child(6) > div > span");
        public IWebElement LblEducation => driver.FindElement(EducationLbl);

        private By PersonalData = By.CssSelector("#emg-body-overlay > div > div > div.menu-container.sidebar-container > div > ul > li.is-active > a");
        public IWebElement BtnPersonalData => driver.FindElement(PersonalData);

        private By WrongPhoneNumber = By.CssSelector("#detailsForm > fieldset > div:nth-child(4) > div > span.gui-input-explain");
        public IWebElement LblWrongPhoneNumber => driver.FindElement(WrongPhoneNumber);


        //Pentru Editare Nickname
        private By InitialBubble = By.CssSelector("#emg-body-overlay > div > div > div.menu-container.sidebar-container > div > div > div.user-avatar.user-avatar-xl > div > span");
        public IWebElement LblInitialBubble => driver.FindElement(InitialBubble);

        private By InitialExtended = By.CssSelector("#emg-body-overlay > div > div > div.menu-container.sidebar-container > div > div > div.title.mrg-top-xs > p.nickname");
        public IWebElement LblInitialExtended => driver.FindElement(InitialExtended);

        private By InitialNavbar = By.CssSelector("#emg-user-menu > div > div > div > span");
        public IWebElement LblInitialNavbar => driver.FindElement(InitialNavbar);


        //Pentru Adaugarea Unei Adrese + Stergerea Ei
        private By AddAddress = By.CssSelector("#emg-body-overlay > div > div > div.user-account-content.page-container > div.user-account-content-here.white.newAccountContainer.newAccountContainerDetails > div > div:nth-child(5) > button");
        public IWebElement BtnAddAddress => driver.FindElement(AddAddress);

        private By AddAddressName = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(3) > div:nth-child(1) > div > input");
        public IWebElement TxtAddAddressName => driver.FindElement(AddAddressName);

        private By AddAddressPhone = By.CssSelector("#phone");
        public IWebElement TxtAddAddressPhone => driver.FindElement(AddAddressPhone);

        private By AddressJudet = By.CssSelector("#region > optgroup:nth-child(2) > option");
        public IList<IWebElement> LstAddressJudet => driver.FindElements(AddressJudet);

        private By AddressLocalitate = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(6) > div:nth-child(2) > div > select > option");
        public IList<IWebElement> LstAddressLocalitate => driver.FindElements(AddressLocalitate);

        private By AddAddressAddress = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(8) > div > input");
        public IWebElement TxtAddAddressAddress => driver.FindElement(AddAddressAddress);

        private By AddressSaveAddress = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > button");
        public IWebElement BtnAddressSaveAddress => driver.FindElement(AddressSaveAddress);

        private By AddressNamePhone = By.ClassName("content-title");
        public IWebElement LblAddressNamePhone => driver.FindElement(AddressNamePhone);

        private By AddressFullAddress = By.ClassName("address_street");
        public IWebElement LblAddressFullAddress => driver.FindElement(AddressFullAddress);

        //sa am grija sa schimb din cod data-id ul DUPA UN REFRESH........
        private By AddressDelete  = By.CssSelector("#account-address-54039502");
        public IWebElement BtnAddressDelete => driver.FindElement(AddressDelete);

        private By AddressDeleteYes = By.CssSelector("#yes > span.btn");
        public IWebElement BtnAddressDeleteYes => driver.FindElement(AddressDeleteYes);

        private By AddressDeleted = By.CssSelector("#addressNotAdded");
        public IWebElement LblAddressDeleted=> driver.FindElement(AddressDeleted);


        //Pentru Editarea Adresei
        //sa am grija sa schimb din cod data-id ul DUPA UN REFRESH........
        private By AddressEdit = By.CssSelector("#address_54040065 > div.content-actions > span.gui-btn.gui-btn-escape.btn-edit-address");
        public IWebElement BtnAddressEdit => driver.FindElement(AddressEdit);

        private By EditAddressName = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(3) > div:nth-child(1) > div > input");
        public IWebElement TxtEditAddressName => driver.FindElement(AddAddressName);

        private By EditAddressPhone = By.CssSelector("#phone");
        public IWebElement TxtEditAddressPhone => driver.FindElement(EditAddressPhone);

        private By EditAddressJudet = By.CssSelector("#region > optgroup:nth-child(3) > option");
        public IList<IWebElement> LstEditAddressJudet => driver.FindElements(EditAddressJudet);

        //private By EditAddressLocalitate = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(6) > div:nth-child(2) > div > select > option");
        //public IList<IWebElement> LstEditAddressLocalitate => driver.FindElements(EditAddressLocalitate);

        private By EditAddressAddress = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > fieldset > div:nth-child(8) > div > input");
        public IWebElement TxtEditAddressAddress => driver.FindElement(EditAddressAddress);

        private By AddressSaveEditedAddress = By.CssSelector("body > div.emg-modal-overlay.fade.in > div.emg-modal > div.emg-modal-content > form > button");
        public IWebElement BtnAddressSaveEditedAddress => driver.FindElement(AddressSaveEditedAddress);

        private By AddressEditedNamePhone = By.ClassName("content-title");
        public IWebElement LblAddressEditedNamePhone => driver.FindElement(AddressEditedNamePhone);

        private By AddressEditedFullAddress = By.ClassName("address_street");
        public IWebElement LblAddressEditedFullAddress => driver.FindElement(AddressEditedFullAddress);



        public void FillData()
        {
            //LstGender[1].Click();
            TxtName.Clear();
            TxtName.SendKeys("numetest");
            TxtNickname.Clear();
            TxtNickname.SendKeys("testnick");
            TxtPhone.Clear();
            TxtPhone.SendKeys("0747557084");
            TxtPhoneFix.Clear();
            TxtPhoneFix.SendKeys("0232268907");

            foreach (var day in LstDay)
            {
                if (day.Text.Equals("17"))
                {
                    day.Click();
                    break;
                }
            }

            foreach (var month in LstMonth)
            {
                if (month.Text.Equals("04"))
                {
                    month.Click();
                    break;
                }
            }

            foreach (var year in LstYear)
            {
                if (year.Text.Equals("1998"))
                {
                    year.Click();
                    break;
                }
            }

            foreach (var edu in LstEducation)
            {
                if (edu.Text.Equals("MBA"))
                {
                    edu.Click();
                    break;
                }
            }
            Thread.Sleep(10000); //pt verificari
        }

        public void SaveData()
        {
            BtnSave.Click();
        }

        public void CheckData()
        {
            Thread.Sleep(10000); //pt verificari
            BtnPersonalData.Click();
        }

        public void AddWrongPhoneNumber()
        {
            TxtPhone.SendKeys("hhhhhhhhhhhhh");
        }

        public void AddNickname()
        {
            TxtNickname.Clear();
            TxtNickname.SendKeys("xpertqa");
        }

        public void AddWrongBirthDate()
        {

            foreach (var day in LstDay)
            {
                if (day.Text.Equals("30"))
                {
                    day.Click();
                    break;
                }
            }

            foreach (var month in LstMonth)
            {
                if (month.Text.Equals("02"))
                {
                    month.Click();
                    break;
                }
            }

        }

        public void FillDataAddress()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(AddAddressName));
            TxtAddAddressName.Clear();
            TxtAddAddressName.SendKeys("Alex Teo");
            TxtAddAddressPhone.Clear();
            TxtAddAddressPhone.SendKeys("0747832509");

            foreach (var judet in LstAddressJudet)
            {
                if (judet.Text.Equals("Iași"))
                {
                    judet.Click();
                    break;
                }
            }

            foreach (var localitate in LstAddressLocalitate)
            {
                if (localitate.Text.Equals("Iași"))
                {
                    localitate.Click();
                    break;
                }
            }

            TxtAddAddressAddress.Clear();
            TxtAddAddressAddress.SendKeys("Strada Soarelui nr. 12");

        }

        public void AddAddressButton()
        {
            Thread.Sleep(2000); //pt verificari
            BtnAddAddress.Click();
        }

        public void SaveAddress()
        {
            BtnAddressSaveAddress.Click();
            Thread.Sleep(3000); //pt verificari

        }

        public void WaitALilBit()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(AddressNamePhone));
        }

        public bool CheckIfDeleteButtonExists()
        {
            //sa am grija sa schimb din cod data-id ul DUPA UN REFRESH........
            var by = By.CssSelector("#account-address-54039502");
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void DeleteAddress()
        {
            Thread.Sleep(4000); //pt verificari
            BtnAddressDelete.Click();
            Thread.Sleep(4000); //pt verificari
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(AddressDeleteYes));
            BtnAddressDeleteYes.Click();
            Thread.Sleep(4000); //pt verificari
            wait.Until(ExpectedConditions.ElementIsVisible(AddressDeleted));
        }


        public void EditDataAddress()
        {
            Thread.Sleep(5000); //pt verificari
            BtnAddressEdit.Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(EditAddressName));
            TxtEditAddressName.Clear();
            TxtEditAddressName.SendKeys("Dani Sergiu");
            TxtEditAddressPhone.Clear();
            TxtEditAddressPhone.SendKeys("0788888888");

            foreach (var judet in LstEditAddressJudet)
            {
                if (judet.Text.Equals("Timiș"))
                {
                    judet.Click();
                    break;
                }
            }

            foreach (var localitate in LstAddressLocalitate)
            {
                if (localitate.Text.Equals("Balinț"))
                {
                    localitate.Click();
                    break;
                }
            }

            TxtEditAddressAddress.Clear();
            TxtEditAddressAddress.SendKeys("Aleea Rozelor nr. 1");

            Thread.Sleep(5000); //pt verificari

        }

        public void SaveEditedAddress()
        {
            BtnAddressSaveEditedAddress.Click();
            Thread.Sleep(3000); //pt verificari

        }

        public void WaitALilBitMore()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(AddressEditedNamePhone));
        }



    }


}
