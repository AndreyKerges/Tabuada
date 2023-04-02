
using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarações de três variáveis inteiras
            int formula, contador, numero;

            //exibe a mensagem "-----TABUADA-----" no console
            Console.WriteLine("-----TABUADA-----");

            //exibe a mensagem "Digite um número : " no console
            Console.Write("Digite um número : ");
            // armazena na variável "numero" o valor digitado pelo usuário, convertido para inteiro
            numero = Int32.Parse(Console.ReadLine()!);

            // laço de repetição que vai de 1 a 10
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador; //calcula o valor da tabuada (multiplicação entre o número digitado e o contador do laço)
                Console.WriteLine(numero + " X " + contador + " = " + formula); //exibe na tela a linha correspondente da tabuada
            }
            Console.ReadLine(); //aguarda uma tecla ser pressionada antes de encerrar o programa
        }
    }
}