using System.Net.Http.Headers;

namespace URI1005Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso1 = 3.5, peso2 = 7.5;
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double media = ((A * peso1) + (B * peso2)) / (peso1 + peso2);

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}
