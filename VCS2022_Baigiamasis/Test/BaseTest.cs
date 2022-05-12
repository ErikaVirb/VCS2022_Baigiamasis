using Baigiamasis_Darbas.Drivers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCS2022_Baigiamasis.Page;
using VCS2022_Baigiamasis.Tools;

namespace VCS2022_Baigiamasis.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static SafloraProduktoKainaPage _safloraProduktoKainaPage;
        public static SafloraPrisijungimasPage _safloraPrisijungimasPage;
        public static SafloraPrekesKrepselyjePage _safloraPrekesKrepselyjePage;
        public static SafloraPrekiuKrepselioSumaPage _safloraPrekiuKrepselioSumaPage;
        public static SafloraPrekiuKrepselioIstustinimasPage _safloraPrekiuKrepselioIstustinimasPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _safloraProduktoKainaPage = new SafloraProduktoKainaPage(Driver);
            _safloraPrisijungimasPage = new SafloraPrisijungimasPage(Driver);
            _safloraPrekesKrepselyjePage = new SafloraPrekesKrepselyjePage(Driver);
            _safloraPrekiuKrepselioSumaPage = new SafloraPrekiuKrepselioSumaPage(Driver);
            _safloraPrekiuKrepselioIstustinimasPage = new SafloraPrekiuKrepselioIstustinimasPage(Driver);
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakesScreenshot.TakeScreenshot(Driver);
            }
        }

    }
}
