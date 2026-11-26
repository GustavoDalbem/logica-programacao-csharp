using System;
using System.Globalization;

namespace URI1010CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] peca = Console.ReadLine().Split(' ');
            int codigo = int.Parse(peca[0]);
            int quantidade = int.Parse(peca [1]);
            double preco = double.Parse(peca [2]);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double preco2 = double.Parse(peca2[2]);

            double total = (quantidade * preco) + (quantidade2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
