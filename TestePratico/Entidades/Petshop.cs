using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico
{
    public class TaxasBanho
    {
        public double CaoPequeno { get; set; }
        public double CaoGrande { get; set; }
    }

    public class Petshop
    {
        public string Nome { get; set; }
        public double Distancia { get; private set; }
        public TaxasBanho TaxasDiaDeSemana { get; private set; }
        public TaxasBanho TaxasFimDeSemana { get; private set; }


        public Petshop(string nome, double distancia,
            double taxaBanhoDiaDeSemana_P, double taxaBanhoDiaDeSemana_G,
            double taxaBanhoFimDeSemana_P, double taxaBanhoFimDeSemana_G)
        {
            Nome = nome;
            Distancia = distancia;

            TaxasDiaDeSemana = new TaxasBanho
            {
                CaoPequeno = taxaBanhoDiaDeSemana_P,
                CaoGrande = taxaBanhoDiaDeSemana_G
            };

            TaxasFimDeSemana = new TaxasBanho
            {
                CaoPequeno = taxaBanhoFimDeSemana_P,
                CaoGrande = taxaBanhoFimDeSemana_G
            };
        }

        public double CalcularCusto(int diaDaSemana, int CaesPequenos, int CaesGrandes)
        {
            double custoTotal;

            TaxasBanho taxas = TaxasFimDeSemana;

            if(diaDaSemana > 0 && diaDaSemana < 6)
            {
                taxas = TaxasDiaDeSemana;
            }

            custoTotal = taxas.CaoPequeno * CaesPequenos + (taxas.CaoGrande * CaesGrandes);
            return custoTotal;
        }
    }
}
