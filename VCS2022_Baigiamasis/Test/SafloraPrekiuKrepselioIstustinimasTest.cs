using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraPrekiuKrepselioIstustinimasTest : BaseTest
    {
        [Test]
        public static void PrekiuKrepselioIstustinimas()
        {
            _safloraPrekiuKrepselioIstustinimasPage.NavigateToDefaultPage();
            _safloraPrekiuKrepselioIstustinimasPage.Hidrolatai();
            _safloraPrekiuKrepselioIstustinimasPage.Preke();
            _safloraPrekiuKrepselioIstustinimasPage.PrekeIKrepseli();
            _safloraPrekiuKrepselioIstustinimasPage.KrepselisButton();
            _safloraPrekiuKrepselioIstustinimasPage.AtsisakytiPrekiu();
           
        }
    }
}
