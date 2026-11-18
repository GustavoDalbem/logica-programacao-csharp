using System;
using System.Globalization;

namespace ProcessamentoDeDadosEmCSharpCasting
{
    class Program
    {
        // Main = ponto de entrada. Ele só chama o teste que eu quero rodar.

        static void Main(string[] args)
        {
            Teste4();

            Console.ReadLine();
        }

        // Teste 1: 
        static void Teste1()
        {
            int x, y;

            x = 5;

            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        // Teste 2: 
        static void Teste2()
        {
            double b, B, h, area; // float b, B, h, area; 

            b = 6.0; // 2f
            B = 8.0; // 8f
            h = 5.0; // 5f

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);

            Console.ReadLine();
        }

        //teste 3:
        static void Teste3()
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double)a / b;

            Console.WriteLine(resultado);
        }

        //teste 4:
        static void Teste4()
        {
            double a;
            int b;

            a = 5.0;
            b = (int) a;

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
