using System;

namespace URI1006Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 2, pesoB = 3, pesoC = 5;

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double resultado = ((A * pesoA) + (B * pesoB) + (C * pesoC)) / (pesoA + pesoB + pesoC);
            
            Console.WriteLine("MEDIA = " + resultado.ToString("F1"));
        }
    }
}
