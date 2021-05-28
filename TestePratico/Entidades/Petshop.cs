using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico
{
    class Petshop
    {
        //Nome do Petshop
        public string Nome { get; set; }
        public double Distancia { get; private set; }
        public double TaxaBanhoDiaDeSemana_P { get; private set; }
        public double TaxaBanhoDiaDeSemana_G { get; private set; }
        public double TaxaBanhoFimDeSemana_P { get; private set; }
        public double TaxaBanhoFimDeSemana_G { get; private set; }


        //Construtor
        public Petshop(string nome, double distancia,
            double taxaBanhoDiaDeSemana_P, double taxaBanhoDiaDeSemana_G,
            double taxaBanhoFimDeSemana_P, double taxaBanhoFimDeSemana_G)
        {
            Nome = nome;
            Distancia = distancia;
            TaxaBanhoDiaDeSemana_P = taxaBanhoDiaDeSemana_P;
            TaxaBanhoDiaDeSemana_G = taxaBanhoDiaDeSemana_G;
            TaxaBanhoFimDeSemana_P = taxaBanhoFimDeSemana_P;
            TaxaBanhoFimDeSemana_G = taxaBanhoFimDeSemana_G;
        }

    }
    }

