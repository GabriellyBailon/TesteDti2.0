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
        public double Custo { get; set; }


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

        //Calcula custo dos banhos dos cachorros

        public void SetCusto(int diaDaSemana, int quantidadeCaesP, int quantidadeCaesG)
        {
            double _custoTotal;

            _custoTotal = (diaDaSemana > 0 && diaDaSemana < 6) ?
                (this.TaxaBanhoDiaDeSemana_P * quantidadeCaesP) + (this.TaxaBanhoDiaDeSemana_G * quantidadeCaesG) :
                (this.TaxaBanhoFimDeSemana_P * quantidadeCaesP) + (this.TaxaBanhoFimDeSemana_G * quantidadeCaesG);

            Custo = _custoTotal;
        }

    }
    }

