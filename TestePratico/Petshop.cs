using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico

    // O que quero fazer
    //Petshop seja interface e cada petshop uma classe
    //Melhor preço e Desempate retorne uma lista com nome e valor,
    //aí então retirar as propriedades MelhorPreco e NomeMelhorPreco
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
        public static double MelhorPreco { get; private set; }
        public static string NomeMelhorPreco { get; private set; }

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
        public static double CalculaMelhorPreco(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            double melhorPreco;

            if (custoMeuCaninoFeliz < custoVaiRex && custoMeuCaninoFeliz < custoChowChawgas)
            {
                MelhorPreco = melhorPreco = custoMeuCaninoFeliz;
                NomeMelhorPreco = "Meu Canino Feliz";

            }
            else if (custoVaiRex < custoMeuCaninoFeliz && custoVaiRex < custoChowChawgas)
            {
                MelhorPreco = melhorPreco = custoVaiRex;
                NomeMelhorPreco = "Vai Rex";
            }
            else if (custoChowChawgas < custoMeuCaninoFeliz && custoChowChawgas < custoVaiRex)
            {
                MelhorPreco = melhorPreco = custoChowChawgas;
                NomeMelhorPreco = "ChowChawgas";
            }
            else
            {
                melhorPreco = Desempate(custoMeuCaninoFeliz, custoVaiRex, custoChowChawgas);
               
            }
            return melhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static double Desempate(double custoMeuCaninoFeliz, double custoVaiRex, double custoChowChawgas)
        {
            double melhorPreco = 0;

            if (custoMeuCaninoFeliz == custoChowChawgas || custoVaiRex == custoChowChawgas)
            {
                melhorPreco = custoChowChawgas;
                NomeMelhorPreco = "ChowChawgas";
            }
            else if (custoMeuCaninoFeliz == custoVaiRex)
            {
                melhorPreco = custoVaiRex;
                NomeMelhorPreco = "Vai Rex";
            }

            return melhorPreco;

        }



    }


    }

