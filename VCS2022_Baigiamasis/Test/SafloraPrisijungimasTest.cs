using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS2022_Baigiamasis.Test
{
    class SafloraPrisijungimasTest : BaseTest
    {
        [Test]
        public static void Prisijungimas()
        {
            _safloraPrisijungimasPage.NavigateToDefaultPage();
            _safloraPrisijungimasPage.ManoPaskyra();
            _safloraPrisijungimasPage.ElPastoInput("skirmantas.skirmantas@yahoo.com");
            _safloraPrisijungimasPage.SlaptazodioInput("ManopaskyraSkirmantas");
            _safloraPrisijungimasPage.PrisijungtiButton();
            _safloraPrisijungimasPage.ArTeisingaiPrilogino();
            _safloraPrisijungimasPage.Atsijungti();

        }
    }
}
