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

        //Calcula custo dos banhos dos cachorros
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

        //Dados os custos dos bahos, retorna o valor do menor preço
        //Analisar a possibilidade de usar params
        public static List<string> CalculaMelhorPreco(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            List<string> dadosMelhorPreco = new List<string>();

            if (custoMeuCaninoFeliz < custoVaiRex && custoMeuCaninoFeliz < custoChowChawgas)
            {
                dadosMelhorPreco.Add("Meu Canino Feliz");
                dadosMelhorPreco.Add(custoMeuCaninoFeliz.ToString("F2"));

            }
            else if (custoVaiRex < custoMeuCaninoFeliz && custoVaiRex < custoChowChawgas)
            {
                dadosMelhorPreco.Add("Vai Rex");
                dadosMelhorPreco.Add(custoVaiRex.ToString("F2"));
            }
            else if (custoChowChawgas < custoMeuCaninoFeliz && custoChowChawgas < custoVaiRex)
            {
                dadosMelhorPreco.Add("ChowChawgas");
                dadosMelhorPreco.Add(custoChowChawgas.ToString("F2"));
            }
            else
            {
                dadosMelhorPreco = Desempate(custoMeuCaninoFeliz, custoVaiRex, custoChowChawgas);
               
            }
            return dadosMelhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static List<string> Desempate(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            List<string> dadosMelhorPreco = new List<string>();

            if (custoMeuCaninoFeliz == custoChowChawgas || custoVaiRex == custoChowChawgas)
            {
                dadosMelhorPreco.Add("ChowChawgas");
                dadosMelhorPreco.Add(custoChowChawgas.ToString("F2"));
            }
            else if (custoMeuCaninoFeliz == custoVaiRex)
            {
                dadosMelhorPreco.Add("Vai Rex");
                dadosMelhorPreco.Add(custoVaiRex.ToString("F2"));
            }

            return dadosMelhorPreco;

        }



    }


    }

