using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraProduktoKainaTest : BaseTest
    {
        [Test]
        public static void ProduktoKaina()
        {
            _safloraProduktoKainaPage.NavigateToDefaultPage();
            _safloraProduktoKainaPage.PlaukamsButton();
            _safloraProduktoKainaPage.PasirenkamPrekeAtkuriamasis();
            _safloraProduktoKainaPage.IKrepseli();
            _safloraProduktoKainaPage.PapildomaInfoIcon();
            _safloraProduktoKainaPage.TarosTalposPatikrinimas();
            _safloraProduktoKainaPage.PrekesKainosPatikrinimas();
            _safloraProduktoKainaPage.PerziuretiKrepseliIcon();
            _safloraProduktoKainaPage.KainosTikrinimas();
        }
    }
}
