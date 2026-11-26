using System.Numerics;

namespace URI1014Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivel;

            distancia = int.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine());

            double Total = distancia / combustivel;


            Console.WriteLine(Total.ToString("F3") + " km/l");

            Console.ReadLine();

        }
    }
}
