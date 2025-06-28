using System;
using Projetos;
using Exercicios;



namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            menuProjects menuInterativo = new menuProjects();

            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.WriteLine("          MENU INTERATIVO          ");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");

            Console.Write("Escolha o programa:\n 1- Calcular Média\n 2- Par ou Impar\n 3- Calculadora utilizando Switch\n 4- Classificador de Idade \n");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("===================================");
                        Console.WriteLine("        Calculador de Média        ");
                        Console.WriteLine("===================================");
                        menuInterativo.aprovadoReprovado();
                        break;
                    case 2:
                        Console.WriteLine("===================================");
                        Console.WriteLine("            Par ou Impar           ");
                        Console.WriteLine("===================================");
                        menuInterativo.parImpar();
                        break;
                    case 3:
                        Console.WriteLine("===================================");
                        Console.WriteLine("   Calculadora utilizando Switch   ");
                        Console.WriteLine("===================================");
                        menuInterativo.calculadoraSwitch();
                        break;
                    case 4:
                        Console.WriteLine("===================================");
                        Console.WriteLine("      Classificador de Idade       ");
                        Console.WriteLine("===================================");
                        menuInterativo.classificadorIdade();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

            Exercicio Training = new Exercicio();

        }
        
    }
}