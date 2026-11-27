using System;

namespace URI1017GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tempoViagem = int.Parse(Console.ReadLine());
            int GastoViagem = int.Parse(Console.ReadLine());


            double resultado = ((double)GastoViagem / 12) * tempoViagem;

            Console.WriteLine(resultado.ToString("F3"));
            
            
            
            Console.ReadLine();
        }
    }
}
