using System;

namespace URI1008Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IdFuncionario, HoraTrab;
            double SalHora, Salario;

            IdFuncionario = int.Parse(Console.ReadLine());
            HoraTrab = int.Parse(Console.ReadLine());
            SalHora = double.Parse(Console.ReadLine());

            Salario =  HoraTrab * SalHora;

            Console.WriteLine("NUMBER = " + IdFuncionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"));

        }
    }
}
