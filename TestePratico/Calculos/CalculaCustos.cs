using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico.Calculos
{
    class CalculaCustos
    {
        //Calcula custo dos banhos dos cachorros

        public static double CustoTotal(int diaDaSemana, int quantidadeCaesP, int quantidadeCaesG, Petshop petshop)
        {
            double custoTotal;

            //Cálculo feito para pesquisa de segunda a sexta
            //Era um if/else
            custoTotal = (diaDaSemana > 0 && diaDaSemana < 6) ?
                (petshop.TaxaBanhoDiaDeSemana_P * quantidadeCaesP) + (petshop.TaxaBanhoDiaDeSemana_G * quantidadeCaesG) :
                (petshop.TaxaBanhoFimDeSemana_P * quantidadeCaesP) + (petshop.TaxaBanhoFimDeSemana_G * quantidadeCaesG);

            return custoTotal;
        }

        //Dados os custos dos bahos, retorna o valor do menor preço
        //Analisar a possibilidade de usar params
        public static List<string> CalculaMelhorPreco(List<double> custos)
        {
            //Custo 0: Meu Canino Feliz
            //Custo 1: Vai Rex
            //Custo 2: ChowChawgas

            List<string> dadosMelhorPreco = new List<string>();

            if (custos[0] < custos[1] && custos[0] < custos[2])
            {
                dadosMelhorPreco.Add("Meu Canino Feliz");
                dadosMelhorPreco.Add(custos[0].ToString("F2"));

            }
            else if (custos[1] < custos[0] && custos[1] < custos[2])
            {
                dadosMelhorPreco.Add("Vai Rex");
                dadosMelhorPreco.Add(custos[1].ToString("F2"));
            }
            else if (custos[2] < custos[0] && custos[2] < custos[1])
            {
                dadosMelhorPreco.Add("ChowChawgas");
                dadosMelhorPreco.Add(custos[2].ToString("F2"));
            }
            else
            {
                dadosMelhorPreco = Desempate(custos);

            }
            return dadosMelhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static List<string> Desempate(List<double> custos)
        {
            List<string> dadosMelhorPreco = new List<string>();

            if (custos[0] == custos[2] || custos[1] == custos[2])
            {
                dadosMelhorPreco.Add("ChowChawgas");
                dadosMelhorPreco.Add(custos[2].ToString("F2"));
            }
            else if (custos[0] == custos[1])
            {
                dadosMelhorPreco.Add("Vai Rex");
                dadosMelhorPreco.Add(custos[1].ToString("F2"));
            }

            return dadosMelhorPreco;

        }
    }
}
