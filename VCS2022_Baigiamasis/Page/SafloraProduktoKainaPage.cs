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
    class SafloraProduktoKainaPage : BasePage
    {
        public SafloraProduktoKainaPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _plaukamsButton => Driver.FindElement(By.CssSelector("#menu-item-442 > a"));
        private IWebElement _atkuriamasis => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-15002.product.type-product.status-publish.has-post-thumbnail.product_cat-plaukams.first.instock.shipping-taxable.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link > h3"));
        private IWebElement _iKrepseli => Driver.FindElement(By.CssSelector("#product-15002 > div.summary.entry-summary > div.cart_add > form > button"));
        private IWebElement _papildomaInfoIcon => Driver.FindElement(By.CssSelector("#product-15002 > div.woocommerce-tabs.wc-tabs-wrapper > ul > li.additional_information_tab > a"));
        private IWebElement _talpa => Driver.FindElement(By.CssSelector("#tab-additional_information > table > tbody > tr.woocommerce-product-attributes-item.woocommerce-product-attributes-item--attribute_pa_volume > td"));
        private IWebElement _kaina => Driver.FindElement(By.CssSelector("#product-15002 > div.summary.entry-summary > div.cart_add > form > div.price_container > p > span"));
        private IWebElement _perziuretiKrepseliButton => Driver.FindElement(By.CssSelector("#bg > div.bg_head > div.head_top_container > div.wrapper_p.top_header > div.top_con > div.toph_r > ul > li > div > div.cart_top > a"));
        private IWebElement _tikrinamKaina => Driver.FindElement(By.CssSelector("#page-373 > div.woocommerce > form > div > table > tbody > tr:nth-child(1) > td > div > table > tbody > tr.order-total > td > strong > span"));
        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }
        public void PlaukamsButton()
        {
            _plaukamsButton.Click();
        }
        public void PasirenkamPrekeAtkuriamasis()
        {
            _atkuriamasis.Click();
        }
        public void IKrepseli()
        {
            _iKrepseli.Click();
        }
        public void PapildomaInfoIcon()
        {
            _papildomaInfoIcon.Click();
        }

        public void TarosTalposPatikrinimas()
        {
            Assert.AreEqual("150 ml", _talpa.Text, "150 ml");
        }
        public void PrekesKainosPatikrinimas()
        {
            Assert.AreEqual("9.30 €", _kaina.Text, "9.30 €");
        }
        public void PerziuretiKrepseliIcon()
        {
            _perziuretiKrepseliButton.Click();
        }
        public void KainosTikrinimas()
        {
            Assert.AreEqual("9.30 €", _tikrinamKaina.Text, "9.30 €");
        }

    }
}
