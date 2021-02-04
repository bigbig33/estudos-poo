using System;

namespace AreaTrianfulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Double b = 0;
            Double altura = 0;

            Console.Write("Digite a base do triangulo:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do triangulo:");
            altura = Convert.ToDouble(Console.ReadLine());

            Double area = b * altura;
            Double areaTriangulo = area / 2;

            Console.WriteLine("A area do triangulo é " + areaTriangulo);
            
        }
    }
}
