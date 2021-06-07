using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico.Entidades
{
    class ChowChawgas : IPetshop
    {
        public ChowChawgas()
        {
            Nome = "ChowChawgas";
            Distancia = 800;
            TaxaBanhoDiaDeSemana_P = 30.00;
            TaxaBanhoDiaDeSemana_G = 45.00;
            TaxaBanhoFimDeSemana_P = 30.00;
            TaxaBanhoFimDeSemana_G = 45.00;

        }
    }
}
