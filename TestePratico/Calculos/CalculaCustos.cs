using System.Collections.Generic;
using System.Linq;

namespace TestePratico.Calculos
{
    class CalculaCustos
    {
        //Constante de referência, maior que a maior distância que temos nas informações dos Petshops
        public const double maiorDistancia = 2100;

        public static List<string> CalculaMelhorPreco(List<Orcamento> orcamentos)
        {
            List<string> _dadosMelhorPreco = new List<string>();

            double melhorCusto = orcamentos[0].Custo;
            Petshop petshopMelhorPreco =  orcamentos[0].PetShop;

            //Analisando cada preço de Petshop passado e seta o menor valor
            foreach (Orcamento orcamento in orcamentos)
            {
                if (orcamento.Custo < melhorCusto)
                {
                    melhorCusto = orcamento.Custo;
                    petshopMelhorPreco = orcamento.PetShop;
                }
            }

            //Analisa se o menor valor encontrado se repetiu mais de uma vez entre os custos
            if (orcamentos.Count(x => x.Custo == melhorCusto) > 1)
            {
                _dadosMelhorPreco = Desempate(melhorCusto, orcamentos);
            }
            else
            {
                _dadosMelhorPreco.Add(petshopMelhorPreco.Nome);
                _dadosMelhorPreco.Add(melhorCusto.ToString("F2"));
            }

            return _dadosMelhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static List<string> Desempate(double melhorCusto, List<Orcamento> orcamentos)
        {
            List<string> _dadosMelhorPreco = new List<string>();
            Petshop petshopMelhorPreco = orcamentos[0].PetShop;
            double menorDistancia = maiorDistancia;

            //Percorre todo o vetor de objetos Petshop
            foreach (Orcamento orcamento in orcamentos)
            {
                //Analisa se o custo do Petshop é igual ao menor custo encontrado
                if(orcamento.Custo == melhorCusto)
                {
                    //Analisa a distância entre os Petshops e retorna o mais próximo
                    if(orcamento.PetShop.Distancia < menorDistancia)
                    {
                        menorDistancia = orcamento.PetShop.Distancia;
                        petshopMelhorPreco = orcamento.PetShop;
                    }
                }
            }

            //Adiciona os dados do Petshop mais próximo à lista de informações do
            //Petshop com as melhores condições
            _dadosMelhorPreco.Add(petshopMelhorPreco.Nome);
            _dadosMelhorPreco.Add(melhorCusto.ToString("F2"));

            return _dadosMelhorPreco;

        }

    }
}

