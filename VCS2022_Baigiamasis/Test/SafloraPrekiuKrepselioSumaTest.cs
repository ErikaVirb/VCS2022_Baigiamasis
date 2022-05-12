using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraPrekiuKrepselioSumaTest : BaseTest
    {

        [Test]
        public static void PrekiuAtsiemimasAdresas()
        {
            _safloraPrekiuKrepselioSumaPage.NavigateToDefaultPage();
            _safloraPrekiuKrepselioSumaPage.DovanosItem();
            _safloraPrekiuKrepselioSumaPage.BukSveikas();
            _safloraPrekiuKrepselioSumaPage.BukSveikasIKrepseli();
            _safloraPrekiuKrepselioSumaPage.DovanosItem1();
            _safloraPrekiuKrepselioSumaPage.DovanuKuponas();
            _safloraPrekiuKrepselioSumaPage.DovanuKuponasIKrepseli();
            _safloraPrekiuKrepselioSumaPage.PerziuretiKrepseliIcon();
            _safloraPrekiuKrepselioSumaPage.SumosTikrinimas();
        }
    }
}
