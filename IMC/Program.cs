using Pessoa;
using System;
using IMC;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");

            Console.Write("Digite o seu peso em kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura em cm: ");
            double alturaCm = Convert.ToDouble(Console.ReadLine());

            PessoaMain PessoaMain = new PessoaMain(peso, alturaCm);
            CalcularIMC calculadora = new CalcularIMC();

            double imc = calculadora.CalculadoraIMC(PessoaMain);
            Console.WriteLine($"Seu IMC é: " + imc);
            Console.WriteLine($"Classificação: " + calculadora.ClassificarIMC(imc));
        }
    }
}
    
   