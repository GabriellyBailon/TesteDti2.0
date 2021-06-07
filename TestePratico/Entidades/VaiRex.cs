using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico.Entidades
{
    class VaiRex : IPetshop
    {
        public VaiRex()
        {
            Nome = "Vai Rex";
            Distancia = 1700;
            TaxaBanhoDiaDeSemana_P = 15.00;
            TaxaBanhoDiaDeSemana_G = 50.00;
            TaxaBanhoFimDeSemana_P = 20.00;
            TaxaBanhoFimDeSemana_G = 55.00;

        }
    }
}
