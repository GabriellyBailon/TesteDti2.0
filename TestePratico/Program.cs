using System;
using System.Globalization;

namespace TestePratico
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dadosData;
            int dia, mes, ano;
            int diaDeHoje;
            int quantidadeP, quantidadeG;
            double custoTotal1, custoTotal2, custoTotal3;
            double melhorCusto;
            string nomePetshopMelhorCusto;

            Petshop meuCaninoFeliz = new Petshop("Meu Canino Feliz", 2000, 20, 40, 24, 48);
            Petshop vaiRex = new Petshop("Vai Rex", 1700, 15, 50, 20, 55);
            Petshop chowChawgas = new Petshop("ChowChawgas", 800, 30, 45, 30, 45);

            Console.WriteLine("Bem-vindo(a) à nossa calculadora do melhor valor!");
            Console.WriteLine("Buscando o melhor preço para cuidar do seu melhor amigo!");

            Console.WriteLine("\nVamos lá!");
            Console.Write("Insira a data de hoje no formato DD/MM/AAAA (com as barrinhas): ");
            dadosData = Console.ReadLine().Split('/');
            dia = int.Parse(dadosData[0]);
            mes = int.Parse(dadosData[1]);
            ano = int.Parse(dadosData[2]);
            diaDeHoje = CalculaDia.DiaDaSemana(dia, mes, ano);

            Console.Write("Qual a quantidade de cãezinhos pequenos? ");
            quantidadeP = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de cãezinhos grandes? ");
            quantidadeG = int.Parse(Console.ReadLine());

            custoTotal1 = meuCaninoFeliz.CustoTotal(diaDeHoje, quantidadeP, quantidadeG);
            custoTotal2 = vaiRex.CustoTotal(diaDeHoje, quantidadeP, quantidadeG);
            custoTotal3 = chowChawgas.CustoTotal(diaDeHoje, quantidadeP, quantidadeG);

            melhorCusto = Petshop.CalculaMelhorPreco(custoTotal1, custoTotal2, custoTotal3);
            nomePetshopMelhorCusto = Petshop.NomeMelhorPreco;

            Console.WriteLine($"\nO melhor valor foi encontrado na {nomePetshopMelhorCusto}" +
                $" por R${melhorCusto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
