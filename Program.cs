using System;
using Exercicios;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            menuInterativo menu = new menuInterativo();

            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.WriteLine("          MENU INTERATIVO          ");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");

            Console.Write("Escolha o programa:\n 1- Calcular Média\n 2- Par ou Impar\n 3- Calculadora utilizando Switch\n 4- Classificador de Idade \n");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("===================================");
                    Console.WriteLine("        Calculador de Média        ");
                    Console.WriteLine("===================================");
                    menu.aprovadoReprovado();
                    break;
                case 2:
                    Console.WriteLine("===================================");
                    Console.WriteLine("            Par ou Impar           ");
                    Console.WriteLine("===================================");
                    menu.parImpar();
                    break;
                case 3:
                    Console.WriteLine("===================================");
                    Console.WriteLine("   Calculadora utilizando Switch   ");
                    Console.WriteLine("===================================");
                    menu.calculadoraSwitch();
                    break;
                case 4:
                    Console.WriteLine("===================================");
                    Console.WriteLine("      Classificador de Idade       ");
                    Console.WriteLine("===================================");
                    menu.classificadorIdade();
                    break;






            }







        }
    }
}