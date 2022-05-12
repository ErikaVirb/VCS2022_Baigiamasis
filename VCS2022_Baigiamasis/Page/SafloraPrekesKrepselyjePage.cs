using Baigiamasis_Darbas.Page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Page
{
    class SafloraPrekesKrepselyjePage : BasePage
    {
        public SafloraPrekesKrepselyjePage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddrress = "https://www.saflora.lt/";

        private IWebElement _dusuiIrvoniaiMeniuButton => Driver.FindElement(By.Id("menu-item-437"));
        private IWebElement _citrusinis => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-574.product.type-product.status-publish.has-post-thumbnail.product_cat-dusui-ir-voniai.product_cat-sveitikliai.first.instock.shipping-taxable.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _citrusinisIKrepseli => Driver.FindElement(By.CssSelector("#product-574 > div.summary.entry-summary > div.cart_add > form > button"));
        private IWebElement _kunuiMeniuButton => Driver.FindElement(By.Id("menu-item-440"));
        private IWebElement _gaivinamasisKoju => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-5893.product.type-product.status-publish.has-post-thumbnail.product_cat-kunui.instock.shipping-taxable.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _gaivinamasisKojuIKrepseli => Driver.FindElement(By.CssSelector("#product-5893 > div.summary.entry-summary > div.cart_add > form > button"));
        private IWebElement _veiduiMeniuButton => Driver.FindElement(By.Id("menu-item-444"));
        private IWebElement _druskosSveitiklis => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-622.product.type-product.status-publish.has-post-thumbnail.product_cat-brandziai-odai.product_cat-dusui-ir-voniai.product_cat-misriai-odai.product_cat-riebiai-ir-normaliai-odai.product_cat-sveitikliai.product_cat-veidui.instock.purchasable.product-type-simple > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _druskosSveitiklisIKrepseli => Driver.FindElement(By.CssSelector("#product-622 > div.summary.entry-summary > div.cart_add > form > button"));
        private IWebElement _garintuvaiMeniuButton => Driver.FindElement(By.Id("menu-item-13258"));
        private IWebElement _aladinasGarintuvas => Driver.FindElement(By.CssSelector("#page > ul > li.col4.product.post-19353.product.type-product.status-publish.has-post-thumbnail.product_cat-garintuvai-difuzoriai.first.instock.shipping-taxable.purchasable.product-type-variable.has-default-attributes > div.product_in.fade_woo > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link"));
        private IWebElement _aladinasGarintuvasIKrepseli => Driver.FindElement(By.CssSelector("#product-19353 > div.summary.entry-summary > form > div > div.woocommerce-variation-add-to-cart.variations_button.woocommerce-variation-add-to-cart-enabled > button"));
        private IWebElement _krepselisButton => Driver.FindElement(By.CssSelector("#bg > div.bg_head > div.head_top_container > div.wrapper_p.top_header > div.top_con > div.toph_r > ul > li > div > div.cart_top > a"));
     

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddrress;
        }
        public void DusuiIrvoniaiMeniuButton()
        {
            _dusuiIrvoniaiMeniuButton.Click();
        }
        public void Citrusinis()
        {
            _citrusinis.Click();
        }
        public void CitrusinisIKrepseli()
        {
            _citrusinisIKrepseli.Click();
        }
        public void KunuiMeniuButton()
        {
            _kunuiMeniuButton.Click();
        }
        public void GaivinamasisKoju()
        {
            _gaivinamasisKoju.Click();
        }
        public void GaivinamasisKojuIKrepseli()
        {
            _gaivinamasisKojuIKrepseli.Click();
        }
        public void VeiduiMeniuButton()
        {
            _veiduiMeniuButton.Click();
        }
        public void DruskosSveitiklis()
        {
            _druskosSveitiklis.Click();
        }
        public void DruskosSveitiklisIKrepseli()
        {
            _druskosSveitiklisIKrepseli.Click();
        }
        public void GarintuvaiMeniuButton()
        {
            _garintuvaiMeniuButton.Click();
        }
        public void AladinasGarintuvas()
        {
            _aladinasGarintuvas.Click();
        }
        public void AladinasGarintuvasIKrepseli()
        {
            _aladinasGarintuvasIKrepseli.Click();

        }
        public void KrepselisButton()
        {
            _krepselisButton.Click();
        }
      

    }
}
