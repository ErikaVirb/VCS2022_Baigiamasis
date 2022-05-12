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
    class SafloraPrekiuAtsiemimasAdresasPage : BasePage
    {
        public SafloraPrekiuAtsiemimasAdresasPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _adresas => Driver.FindElement(By.CssSelector("#text-6 > div > p:nth-child(1) > i.icon-envelope"));

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }
        public void Adresas(string adresas)
        {
            string tikrinamasAdresas = _adresas.Text;
            Assert.IsTrue(tikrinamasAdresas.Equals(adresas), "Adresas neteisingas");
        }





    }
 
}
