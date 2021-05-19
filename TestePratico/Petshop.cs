using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico
{
    class Petshop
    {
        public string Nome { get; set; }
        public double Distancia { get; private set; }
        public double TaxaBanhoDiaDeSemana_P { get; set; }
        public double TaxaBanhoDiaDeSemana_G { get; set; }
        public double TaxaBanhoFimDeSemana_P { get; set; }
        public double TaxaBanhoFimDeSemana_G { get; set; }


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


        public double CustoTotal(int diaDaSemana, int quantidadeCaesP, int quantidadeCaesG)
        {
            double custoTotal;
            //Cálculo feito para pesquisa de segunda a sexta
            if (diaDaSemana > 0 && diaDaSemana < 6)
            {
                custoTotal = (this.TaxaBanhoDiaDeSemana_P * quantidadeCaesP) + (this.TaxaBanhoDiaDeSemana_G * quantidadeCaesG);
            }
            else
            {
                custoTotal = (this.TaxaBanhoFimDeSemana_P * quantidadeCaesP) + (this.TaxaBanhoFimDeSemana_G * quantidadeCaesG);
            }

            return custoTotal;
        }

        public static double MelhorPreco(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            double melhorPreco;

            if(custoMeuCaninoFeliz < custoVaiRex && custoMeuCaninoFeliz < custoChowChawgas)
            {
                melhorPreco = custoMeuCaninoFeliz;
            }
            else if (custoVaiRex < custoMeuCaninoFeliz && custoVaiRex < custoChowChawgas)
            {
                melhorPreco = custoVaiRex;
                Console.WriteLine("Vai Rex");
            }
            else if (custoChowChawgas < custoMeuCaninoFeliz && custoChowChawgas < custoVaiRex)
            {
                melhorPreco = custoChowChawgas;
                Console.WriteLine("ChowChawgas");
            }
            else
            {
                melhorPreco = Desempate(custoMeuCaninoFeliz, custoVaiRex, custoChowChawgas);
            }

            return melhorPreco;
        }

        private static double Desempate(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            double melhorPreco = 0.0;

            if (custoMeuCaninoFeliz == custoChowChawgas || custoVaiRex == custoChowChawgas)
            {
                melhorPreco = custoChowChawgas;
            }
            else if (custoMeuCaninoFeliz == custoVaiRex)
            {
                melhorPreco = custoVaiRex;
            }

            return melhorPreco;
        }
    }

    


}
