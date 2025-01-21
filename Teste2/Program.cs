using System;
using System.Globalization;
namespace Alistamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("   Exercito Brasileiro   ");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("  Cadastro Nacional  ");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Sexo:");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Endereço:");
            string[] valores = Console.ReadLine().Split(',');
            string end = valores[0];
            int numero = int.Parse(valores[1]);
            string complemento = valores[2];

            Console.WriteLine();
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nome da mãe:");
            string mae = Console.ReadLine();

            if (idade <= 17 || idade > 25)
            {
                Console.WriteLine();
                Console.WriteLine("Você esta INAPTO a servir as Forças Armadas");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Você esta APTO a servir as Forças Armadas");
            }
            
            
        }
    }
}
