// Using = importa biblioteca
using System; // Bliblioteca Basica: tem Console, String, Char, etc...
using System.Globalization; // Biblioteca de formatação regional (ex. CultureInfo)

namespace ConsoleApplication2 // é como uma pasta que agrupa e organiza as classes do projeto
{
    class Program // class eh o molde a onde fica o codigo.
    {
        static void Main(String[] args) //Main = ponto de entrada | Void = metodo não retorna nenhum valor | args = argumentos que podem ser passados ao iniciar o programa
        {
            double x = 10.35784; // Double = numero com cassas decimais(ponto flutuante)
            int y = 32; // int = numero intero
            string z = "Maria"; // Texto
            Char w = 'F'; // Um unico caractere, aspas simples

            Console.Write("Ola mundo!"); // Escreve na tela e não pula linha
            Console.Write("Bom dia!"); 
            Console.Write("Ate mais.");

            Console.WriteLine(); // Escreve na tela e pula linha
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // Diminui para 2 casas decimais e arredonda 
            Console.WriteLine(x.ToString("F4")); // Dminui para 4 casas decimais 
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // 2 casas, usando PONTO em vez de vírgula: 10.36

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco eh " + x + " reais");
            Console.WriteLine("O valor do troco eh " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo eh: " + w);

            Console.ReadLine(); // Espera o usuário apertar Enter, para a janela não fechar sozinha
        }
    }
}