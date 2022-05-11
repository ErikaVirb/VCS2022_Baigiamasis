using Baigiamasis_Darbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Page
{
    class SafloraPrisijungimasPage : BasePage

    {
        public SafloraPrisijungimasPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _manoPaskyra => Driver.FindElement(By.LinkText("Mano paskyra /"));
        private IWebElement _elPastoInput => Driver.FindElement(By.Id("username"));
        private IWebElement _slaptazodioInput => Driver.FindElement(By.Id("password"));
        private IWebElement _prisijungtiButton => Driver.FindElement(By.CssSelector("#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button"));
        private IWebElement _rezult => Driver.FindElement(By.CssSelector("#page-375 > div.woocommerce > div > p:nth-child(2) > strong:nth-child(1)"));
        private IWebElement _atsijungti => Driver.FindElement(By.CssSelector("#page-375 > div.woocommerce > nav > ul > li.woocommerce-MyAccount-navigation-link.woocommerce-MyAccount-navigation-link--customer-logout"));

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }
        public void ManoPaskyra()
        {
            _manoPaskyra.Click();
        }
        public void ElPastoInput(string email)
        {
            _elPastoInput.Clear();
            _elPastoInput.SendKeys(email);
        }
        public void SlaptazodioInput(string password)
        {
            _slaptazodioInput.Clear();
            _slaptazodioInput.SendKeys(password);
        }
        public void PrisijungtiButton()
        {
            _prisijungtiButton.Click();
        }
        public void ArTeisingaiPrilogino()
        {
            Assert.AreEqual("skirmantas.skirmantas", _rezult.Text, "Ne ta paskyra");
        }
        public void Atsijungti()
        {
            _atsijungti.Click();
        }

    }
}
