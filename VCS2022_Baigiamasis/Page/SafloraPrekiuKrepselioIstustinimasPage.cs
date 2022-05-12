
using Baigiamasis_Darbas.Page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Page
{
    class SafloraPrekiuKrepselioIstustinimasPage : BasePage
    {
        public SafloraPrekiuKrepselioIstustinimasPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _hidrolataiButton => Driver.FindElement(By.Id("menu-item-439"));
        private IWebElement _preke => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-615.product.type-product.status-publish.has-post-thumbnail.product_cat-hidrolatai.product_cat-misriai-odai.product_cat-probleminei-odai.product_cat-riebiai-ir-normaliai-odai.first.instock.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _prekeIKrepseli => Driver.FindElement(By.CssSelector("#product-615 > div.summary.entry-summary > div.cart_add > form > button"));

        private IWebElement _krepselisButton => Driver.FindElement(By.CssSelector("#bg > div.bg_head > div.head_top_container > div.wrapper_p.top_header > div.top_con > div.toph_r > ul > li > div > div.cart_top > a"));

        private IReadOnlyCollection<IWebElement> _atsisakytiPrekes => Driver.FindElements(By.ClassName("product-remove"));
       
        
        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }
        public void Hidrolatai()
        {
            _hidrolataiButton.Click();

        }
        public void Preke()
        {
            _preke.Click();

        }
        public void PrekeIKrepseli()
        {
            _prekeIKrepseli.Click();
        }

        public void KrepselisButton()
        {
            _krepselisButton.Click();
        }

        public void AtsisakytiPrekiu()
        {

            for (int i = 4; i > _atsisakytiPrekes.Count; i++)
            {
                _atsisakytiPrekes.ElementAt(i).Click();
            }

        }

    }
}
