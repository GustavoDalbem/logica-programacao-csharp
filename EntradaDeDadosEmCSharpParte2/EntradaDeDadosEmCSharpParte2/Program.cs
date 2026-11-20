using System;
using System.Globalization;

namespace EntradaDeDadosEmCSharpParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio();

            Console.ReadLine();
        }

        // Teste 1: convertendo o que foi digitado para outros tipos (Parse)
        // - ReadLine sempre devolve texto (string); int.Parse, char.Parse e
        //   double.Parse convertem esse texto para número ou caractere.
        // - CultureInfo.InvariantCulture faz o double aceitar ponto como decimal.
        // - Split permite ler vários valores de tipos diferentes na mesma linha.
        static void Teste1()
        {
            Console.Write("Digite um numero inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());

            Console.Write("Digite um caractere: ");
            char caractere = char.Parse(Console.ReadLine());

            Console.Write("Digite um numero com casas decimais (use ponto): ");
            double numeroDecimal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite nome, sexo (F/M), idade e altura, separados por espaco: ");
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Voce digitou:");
            Console.WriteLine("Numero inteiro: " + numeroInteiro);
            Console.WriteLine("Caractere: " + caractere);
            Console.WriteLine("Numero decimal: " + numeroDecimal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Exercicio de fixação: ler dados de tipos diferentes e mostrar formatados
        // - Lê nome, número do quarto e preço do produto em linhas separadas.
        // - Lê nome, idade e altura de uma pessoa na mesma linha, usando Split.
        // - Mostra os valores decimais com 2 casas e ponto (F2 + InvariantCulture).
        static void Exercicio()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o numero do quarto: ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            Console.Write("Digite o preco do produto (use ponto): ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite outro nome, idade e altura, separados por espaco: ");
            string[] dados = Console.ReadLine().Split(' ');
            string outroNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quarto: " + numeroQuarto);
            Console.WriteLine("Preco do produto: " + precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Outro nome: " + outroNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
