using Baigiamasis_Darbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Page
{
    class SafloraPrekiuKrepselioSumaPage : BasePage

    {
        public SafloraPrekiuKrepselioSumaPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _dovanosItem => Driver.FindElement(By.CssSelector("#menu-item-4724 > a"));
        private IWebElement _bukSveikas => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-4539.product.type-product.status-publish.has-post-thumbnail.product_cat-dovanos.first.instock.shipping-taxable.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _bukSveikasIKrepseli => Driver.FindElement(By.CssSelector("#product-4539 > div.summary.entry-summary > div.cart_add > form > button"));
        private IWebElement _dovanosItem1 => Driver.FindElement(By.CssSelector("#menu-item-4724 > a"));
        private IWebElement _dovanuKuponas => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-6246.product.type-product.status-publish.has-post-thumbnail.product_cat-dovanos.instock.shipping-taxable.purchasable.product-type-variable.has-default-attributes > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _dovanuKuponasIKrepseli => Driver.FindElement(By.CssSelector("#product-6246 > div.summary.entry-summary > form > div > div.woocommerce-variation-add-to-cart.variations_button.woocommerce-variation-add-to-cart-enabled > button"));

        private IWebElement _perziuretiKrepseliButton => Driver.FindElement(By.CssSelector("#bg > div.bg_head > div.head_top_container > div.wrapper_p.top_header > div.top_con > div.toph_r > ul > li > div > div.cart_top > a"));
        private IWebElement _tikrinamKaina => Driver.FindElement(By.CssSelector("#page-373 > div.woocommerce > form > div > table > tbody > tr:nth-child(1) > td > div > table > tbody > tr.cart-subtotal > td > span"));

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }

        public void DovanosItem()
        {
            _dovanosItem.Click();
        }
        public void BukSveikas()
        {
            _bukSveikas.Click();
        }

        public void BukSveikasIKrepseli()
        {
            _bukSveikasIKrepseli.Click();
        }
        public void DovanosItem1()
        {
            _dovanosItem1.Click();
        }
        public void DovanuKuponas()
        {
            _dovanuKuponas.Click();
        }
        public void DovanuKuponasIKrepseli()
        {
            _dovanuKuponasIKrepseli.Click();
        }
        
        public void PerziuretiKrepseliIcon()
        {
            _perziuretiKrepseliButton.Click();
        }
        public void SumosTikrinimas()
        {
            Assert.AreEqual("28.10 €", _tikrinamKaina.Text, "Suma neteisinga");
        }


    }
}
