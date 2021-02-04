using System;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " X " + i + " = " + resultado);
            }
        }
    }
}
