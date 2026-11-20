using System;
using System.Globalization;

namespace EntradaDeDadosEmCSharpParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste1();

            Console.ReadLine();
        }

        // Teste 1: lendo textos com Console.ReadLine
        // - Cada ReadLine lê uma linha inteira digitada pelo usuário.
        // - Split(' ') quebra uma linha em várias palavras, separando pelos espaços,
        //   e guarda cada palavra numa posição do vetor (começando em 0).
        static void Teste1()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Digite a primeira palavra: ");
            string palavra1 = Console.ReadLine();

            Console.Write("Digite a segunda palavra: ");
            string palavra2 = Console.ReadLine();

            Console.Write("Digite a terceira palavra: ");
            string palavra3 = Console.ReadLine();

            Console.Write("Digite tres palavras na mesma linha, separadas por espaco: ");
            string[] partes = Console.ReadLine().Split(' ');
            string palavraA = partes[0];
            string palavraB = partes[1];
            string palavraC = partes[2];

            Console.WriteLine();
            Console.WriteLine("Voce digitou:");
            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("Primeira palavra: " + palavra1);
            Console.WriteLine("Segunda palavra: " + palavra2);
            Console.WriteLine("Terceira palavra: " + palavra3);
            Console.WriteLine("Palavras da mesma linha: " + palavraA + ", " + palavraB + ", " + palavraC);
        }
    }
}
