using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0;
            float n2 = 0;
            float n3 = 0;
            float n4 = 0;
            float n5 = 0;
            float media = 0;

            
                Console.WriteLine("Informe um número: ");
                n1 = float.Parse(Console.ReadLine());
                n2 = float.Parse(Console.ReadLine());
                n3 = float.Parse(Console.ReadLine());
                n4 = float.Parse(Console.ReadLine());
                n5 = float.Parse(Console.ReadLine());

                media = (n1 + n2 + n3 + n4 + n5) / 5;

                Console.WriteLine("A média é " + media); 
            
            

            
        }
    }
}
