using System;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Exercicios
{
    public class menuInterativo
    {
        public void aprovadoReprovado()
        {
            Console.Write("Digite sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;

            if (media > 7)
            {
                Console.WriteLine("Voce foi aprovado!");
            }
            else if (media > 5 && media < 6.9)
            {
                Console.WriteLine("Voce está de Recuperação");
            }
            else if (media < 5)
            {
                Console.WriteLine("Voce está reprovado!");
            }
            else
            {
                Console.WriteLine("Nota Inválida");
            }

        }
        public void parImpar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é PAR");
            }
            else if (numero % 2 != 0)
            {
                Console.WriteLine($"O número {numero} é IMPAR");
            }
            else
            {
                Console.WriteLine("Esse número é inválido!");
            }
        }
        public void calculadoraSwitch()
        {
            Console.Write("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite mais um número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação: \n 1- Adição (+) \n 2- Subtração (-) \n 3- Multiplicação (*)\n 4- Divisão (/)\n");
            int operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Adição");
                    int adicao = numero1 + numero2;
                    Console.WriteLine($"O resultado é: {adicao}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Subtração");
                    int subtracao = numero1 - numero2;
                    Console.WriteLine($"O resultado é: {subtracao}");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Multiplicação");
                    int multi = numero1 * numero2;
                    Console.WriteLine($"O resultado é: {multi}");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Divisão");
                    int div = numero1 / numero2;
                    Console.WriteLine($"O resultado é: {div}");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;

            }
        }
        public void classificadorIdade()
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade < 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 12 && idade < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 18 && idade < 60)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
        }
    }
}