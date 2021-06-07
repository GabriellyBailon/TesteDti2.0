﻿using System;
using System.Collections.Generic;
using TestePratico.Calculos;
using TestePratico.Entidades;

namespace TestePratico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            string[] dadosData;
            int dia, mes, ano;
            int diaDeHoje;
            int quantidadeP, quantidadeG;
            List<string> melhorCusto;
            string resposta;

            //Criação dos objetos Petshop
            IPetshop meuCaninoFeliz = new MeuCaninoFeliz();
            IPetshop vaiRex = new VaiRex();
            IPetshop chowChawgas = new ChowChawgas();

            //Loop caso o cliente queira repetir o processo
            while (true)
            {
                //Boas vindas
                Console.WriteLine("Bem-vindo(a) à nossa calculadora do melhor valor!");
                Console.WriteLine("Buscando o melhor preço para cuidar do seu melhor amigo!");

                //Inicio da inserção de dados
                Console.WriteLine("\nVamos lá!");
                //Inserção da data
                Console.Write("Insira a data de hoje no formato DD/MM/AAAA (com as barrinhas): ");
                dadosData = Console.ReadLine().Split('/');
                dia = int.Parse(dadosData[0]);
                mes = int.Parse(dadosData[1]);
                ano = int.Parse(dadosData[2]);

                //Calculando o dia atual com os dados passados
                diaDeHoje = CalculaDia.DiaDaSemana(dia, mes, ano);

                //Inserção da quantidade de animais pequenos e grandes
                Console.Write("Qual a quantidade de cãezinhos pequenos? ");
                quantidadeP = int.Parse(Console.ReadLine());
                Console.Write("Qual a quantidade de cãezinhos grandes? ");
                quantidadeG = int.Parse(Console.ReadLine());

                //Cálculo dos custos
                meuCaninoFeliz.SetCusto(diaDeHoje, quantidadeP, quantidadeG);
                vaiRex.SetCusto(diaDeHoje, quantidadeP, quantidadeG);
                chowChawgas.SetCusto(diaDeHoje, quantidadeP, quantidadeG);


                //Lista que guarda nome do Petshop de melhor preço e custo encontrado nele
                melhorCusto = ComparaCustos.CalculaMelhorPreco(meuCaninoFeliz, vaiRex, chowChawgas);

                //Impressão do resultado para o usuário
                Console.WriteLine($"\nO melhor valor foi encontrado na {melhorCusto[0]} por R${melhorCusto[1]}");

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
