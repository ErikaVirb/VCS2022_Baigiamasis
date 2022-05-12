using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraPrekiuAtsiemimasAdresasTest : BaseTest
    {
        [Test]
        public static void PrekiuAtsiemimasAdresas()
        {
            _safloraPrekiuAtsiemimasAdresasPage.NavigateToDefaultPage();
            _safloraPrekiuAtsiemimasAdresasPage.Adresas("+370 6 7045336");

        }

    }
}
