using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.AccessControl;

namespace Exercicios
{
    public class menuInterativo
    {
        public void aprovadoReprovado()
        {
            Console.Write("Digite sua primeira nota: ");
            string? entrada1 = Console.ReadLine();

            Console.Write("Digite sua segunda nota: ");
            string? entrada2 = Console.ReadLine();

            if (double.TryParse(entrada1, out double nota1) && double.TryParse(entrada2, out double nota2))
            {
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
            else
            {
                Console.WriteLine("Valor inválido");
            }

        }
        public void parImpar()
        {
            Console.Write("Digite um número: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
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
            else
            {
                Console.WriteLine("Valor inválido");
            }

        }
        public void calculadoraSwitch()
        {
            Console.Write("Insira um número: ");
            string? entrada1 = Console.ReadLine();

            Console.Write("Insira outro número");
            string? entrada2 = Console.ReadLine();

            if (int.TryParse(entrada1, out int numero1) && int.TryParse(entrada2, out int numero2))
            {
                Console.WriteLine("Escolha a operação: \n 1- Adição (+) \n 2- Subtração (-) \n 3- Multiplicação (*)\n 4- Divisão (/)\n");
                string? entradaOperacao = Console.ReadLine();

                if (int.TryParse(entradaOperacao, out int operacao))
                {
                    Console.Clear();

                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("Adição");
                            Console.WriteLine($"Resultado: {numero1 + numero2}");
                            break;
                        case 2:
                            Console.WriteLine("Subtração");
                            Console.WriteLine($"Resultado: {numero1 - numero2}");
                            break;
                        case 3:
                            Console.WriteLine("Multiplicação");
                            Console.WriteLine($"Resultado: {numero1 * numero2}");
                            break;
                        case 4:
                            Console.WriteLine("Divisão");
                            if (numero2 != 0)
                            {
                                Console.WriteLine($"Resultado: {numero1 / numero2}");
                            }
                            else
                            {
                                Console.WriteLine("Não pode dividir por 0 ");
                            }
                            break;
                        default:
                            Console.WriteLine("Operação Inválida");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }



        }
        public void classificadorIdade()
        {
            Console.Write("Digite sua idade: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int idade))
            {
                if (idade < 0)
                {
                    Console.WriteLine("Idade Inválida");
                }
                else if (idade > 12)
                {
                    Console.WriteLine("Voce é criança");
                }
                else if (idade < 18)
                {
                    Console.WriteLine("Voce é adolescente");
                }
                else if (idade < 60)
                {
                    Console.WriteLine("Voce é adulto");
                }
                else
                {
                    Console.WriteLine("Voce é idoso");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

        }

    }
}