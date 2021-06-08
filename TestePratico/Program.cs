using System;
using System.Collections.Generic;
using TestePratico.Calculos;

namespace TestePratico
{
    public class Orcamento
    {
        public Petshop PetShop { get; set; }
        public double Custo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int diaDeHoje;
            DateTime data;
            int CaesPequenos, CaesGrandes;
            List<string> melhorCusto;
            string resposta;
            double custoMeuCaninoFeliz, custoVaiRex, custoChowChawgas;
            var orcamentos = new List<Orcamento>();

            //Criação dos objetos Petshop
            Petshop meuCaninoFeliz = new Petshop("Meu Canino Feliz", 2000, 20, 40, 24, 48);
            Petshop vaiRex = new Petshop("Vai Rex", 1700, 15, 50, 20, 55);
            Petshop chowChawgas = new Petshop("ChowChawgas", 800, 30, 45, 30, 45);

            //Loop caso o cliente queira repetir o processo
            while (true)
            {
                Console.WriteLine("Bem-vindo(a) à nossa calculadora do melhor valor!");
                Console.WriteLine("Buscando o melhor preço para cuidar do seu melhor amigo!");
                Console.WriteLine("\nVamos lá!");

                //Inserção da data
                Console.Write("Insira a data de hoje no formato DD/MM/AAAA (com as barrinhas): ");
                data = DateTime.Parse(Console.ReadLine());

                //Calculando o dia atual com os dados passados
                diaDeHoje = CalculaDia.DiaDaSemana(data);

                Console.WriteLine(diaDeHoje);

                //Inserção da quantidade de animais pequenos e grandes
                Console.Write("Qual a quantidade de cãezinhos pequenos? ");
                CaesPequenos = int.Parse(Console.ReadLine());
                Console.Write("Qual a quantidade de cãezinhos grandes? ");
                CaesGrandes = int.Parse(Console.ReadLine());

                //Cálculo dos custos
                custoMeuCaninoFeliz = meuCaninoFeliz.CalcularCusto(diaDeHoje, CaesPequenos, CaesGrandes);
                custoVaiRex = vaiRex.CalcularCusto(diaDeHoje, CaesPequenos, CaesGrandes);
                custoChowChawgas = chowChawgas.CalcularCusto(diaDeHoje, CaesPequenos, CaesGrandes);

                Orcamento orcamentoMeuCaninoFeliz = new Orcamento { PetShop = meuCaninoFeliz, Custo = custoMeuCaninoFeliz };
                Orcamento orcamentoVaiRex = new Orcamento { PetShop = vaiRex, Custo = custoVaiRex };
                Orcamento orcamentoChowChawgas = new Orcamento { PetShop = chowChawgas, Custo = custoChowChawgas };

                orcamentos.Add(orcamentoMeuCaninoFeliz);
                orcamentos.Add(orcamentoVaiRex);
                orcamentos.Add(orcamentoChowChawgas);

                //Lista que guarda nome do Petshop de melhor preço e custo encontrado nele
                melhorCusto = CalculaCustos.CalculaMelhorPreco(orcamentos);

                //Impressão do resultado para o usuário
                Console.WriteLine($"\nO melhor valor foi encontrado na {melhorCusto[0]} por R${melhorCusto[1]}");
                //na {melhorCusto[0]}

                Console.WriteLine("Deseja repetir o processo? S/N: ");
                resposta = Console.ReadLine().ToUpper();

                if (resposta[0] == 'N')
                {
                    Console.WriteLine("Até a próxima!");
                    break;
                }

            }
        }
    }
}
