using System;
using System.Globalization; 
namespace ExercicioFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dadosPessoais = Console.ReadLine().Split(' ');
            string ultimoNome = dadosPessoais[0];
            int idade = int.Parse(dadosPessoais[1]);
            double altura = double.Parse(dadosPessoais[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}