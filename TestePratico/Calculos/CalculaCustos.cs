using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestePratico.Calculos
{
    class CalculaCustos
    { 
        public static List<string> CalculaMelhorPreco(List<double> custos)
        {
            //Custo 0: Meu Canino Feliz
            //Custo 1: Vai Rex
            //Custo 2: ChowChawgas

            List<string> _dadosMelhorPreco = new List<string>();
            double melhorCusto = custos[0];
            int indexMelhor = 0;
            string nomeMelhorpreco;

            //Analisa se o custo atual é menor que todos os outros e seta o menor valor
            foreach (double custo in custos)
            {
                if (custo < melhorCusto)
                {
                    melhorCusto = custo;
                    indexMelhor = custos.IndexOf(custo);
                }
            }

            //Analisa se o menor valor encontrado se repetiu mais de uma vez entre os custos
            if (custos.Count(x => x == melhorCusto) > 1)
            {
                _dadosMelhorPreco = Desempate(custos);
            }
            else
            {
                nomeMelhorpreco = RetornaNome(indexMelhor);
                _dadosMelhorPreco.Add(nomeMelhorpreco);
                _dadosMelhorPreco.Add(melhorCusto.ToString("F2"));
            }

            return _dadosMelhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static List<string> Desempate(List<double> custos)
        {
            List<string> _dadosMelhorPreco = new List<string>();

            if (custos[0] == custos[2] || custos[1] == custos[2])
            {
                _dadosMelhorPreco.Add(RetornaNome(2));
                _dadosMelhorPreco.Add(custos[2].ToString("F2"));
            }
            else if (custos[0] == custos[1])
            {
                _dadosMelhorPreco.Add(RetornaNome(1));
                _dadosMelhorPreco.Add(custos[1].ToString("F2"));
            }

            return _dadosMelhorPreco;

        }


        //Função que pega o index e retorna o nome
        private static string RetornaNome(int melhorIndex)
        {
            string _nomeMelhor;

            switch (melhorIndex)
            {
                case 0:
                    _nomeMelhor = "Meu Canino Feliz";
                    break;

                case 1:
                    _nomeMelhor = "Vai Rex";
                    break;

                case 2:
                    _nomeMelhor = "Chow Chawgas";
                    break;

                default:
                    _nomeMelhor = "Petshop ainda não cadastrado";
                    break;
            }

            return _nomeMelhor;
        }
    }
}
