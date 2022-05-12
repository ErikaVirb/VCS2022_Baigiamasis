using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraPrekesKrepselyjeTest : BaseTest
    {
        [Test]
        public static void PrekesKrepselyje()
        {
            _safloraPrekesKrepselyjePage.NavigateToDefaultPage();
            _safloraPrekesKrepselyjePage.DusuiIrvoniaiMeniuButton();
            _safloraPrekesKrepselyjePage.Citrusinis();
            _safloraPrekesKrepselyjePage.CitrusinisIKrepseli();
            _safloraPrekesKrepselyjePage.KunuiMeniuButton();
            _safloraPrekesKrepselyjePage.GaivinamasisKoju();
            _safloraPrekesKrepselyjePage.GaivinamasisKojuIKrepseli();
            _safloraPrekesKrepselyjePage.VeiduiMeniuButton();
            _safloraPrekesKrepselyjePage.DruskosSveitiklis();
            _safloraPrekesKrepselyjePage.DruskosSveitiklisIKrepseli();
            _safloraPrekesKrepselyjePage.GarintuvaiMeniuButton();
            _safloraPrekesKrepselyjePage.AladinasGarintuvas();
            _safloraPrekesKrepselyjePage.AladinasGarintuvasIKrepseli();
            _safloraPrekesKrepselyjePage.KrepselisButton();
            _safloraPrekesKrepselyjePage.AtsisakytiPrekes();
        }
    }
}
