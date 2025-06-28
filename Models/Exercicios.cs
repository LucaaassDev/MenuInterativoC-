using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.AccessControl;

namespace Exercicios
{
    public class Exercicio
    {
        public void exibirMensagem()
        {
            string msg = "Seja Bem vindo ao C#";
            Console.Write("Digite seu nome:");
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{msg}, {input}");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
        public void tiposPrimitivos()
        {
            string name = "Lucas";
            char a = 'A';
            int numberInteger = 21;
            double numberDecimal = 21.6;
            bool Boolean = true;


            Console.WriteLine($"Tipo primitivo String = {name}");
            Console.WriteLine($"Tipo primitivo Char = {a}");
            Console.WriteLine($"Tipo primitivo Inteiro = {numberInteger}");
            Console.WriteLine($"Tipo primitivo Decimal/Double = {numberDecimal}");
            Console.WriteLine($"Tipo primitivo Boolean = {Boolean}");
            
        }

    }
}