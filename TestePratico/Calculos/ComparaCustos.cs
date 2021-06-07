using System.Collections.Generic;
using System.Linq;

namespace TestePratico.Calculos
{
    class ComparaCustos
    {
        //Constante de referência, maior que a maior distância que temos nas informações dos Petshops
        public const double maiorDistancia = 2100;

        public static List<string> CalculaMelhorPreco(params IPetshop[] vetorPetshops)
        {
            List<string> _dadosMelhorPreco = new List<string>();
            double melhorCusto = vetorPetshops[0].Custo;
            IPetshop petshopMelhorPreco = vetorPetshops[0];

            //Analisando cada preço de Petshop passado e seta o menor valor
            foreach (IPetshop petshop in vetorPetshops)
            {
                if (petshop.Custo < melhorCusto)
                {
                    melhorCusto = petshop.Custo;
                    petshopMelhorPreco = petshop;
                }
            }

            //Analisa se o menor valor encontrado se repetiu mais de uma vez entre os custos
            if (vetorPetshops.Count(x => x.Custo == melhorCusto) > 1)
            {
                _dadosMelhorPreco = Desempate(melhorCusto, vetorPetshops);
            }
            else
            {
                _dadosMelhorPreco.Add(petshopMelhorPreco.Nome);
                _dadosMelhorPreco.Add(petshopMelhorPreco.Custo.ToString("F2"));
            }

            return _dadosMelhorPreco;
        }

        //Caso haja empate entre os custos, é chamada a função de desempate
        private static List<string> Desempate(double melhorCusto, params IPetshop[] vetorPetshops)
        {
            List<string> _dadosMelhorPreco = new List<string>();
            IPetshop petshopMelhorPreco = vetorPetshops[0];
            double menorDistancia = maiorDistancia;

            //Percorre todo o vetor de objetos Petshop
            foreach (IPetshop petshop in vetorPetshops)
            {
                //Analisa se o custo do Petshop é igual ao menor custo encontrado
                if (petshop.Custo == melhorCusto)
                {
                    //Analisa a distância entre os Petshops e retorna o mais próximo
                    if (petshop.Distancia < menorDistancia)
                    {
                        menorDistancia = petshop.Distancia;
                        petshopMelhorPreco = petshop;
                    }
                }
            }

            //Adiciona os dados do Petshop mais próximo à lista de informações do
            //Petshop com as melhores condições
            _dadosMelhorPreco.Add(petshopMelhorPreco.Nome);
            _dadosMelhorPreco.Add(petshopMelhorPreco.Custo.ToString("F2"));

            return _dadosMelhorPreco;

        }

    }
}

