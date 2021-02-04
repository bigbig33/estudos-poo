using System;

namespace porcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try{
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                float produto = float.Parse(Console.ReadLine());

                Console.Write("Digite o desconto do produto: ");
                float valorDesconto = float.Parse(Console.ReadLine());

                float porcentagem = valorDesconto / 100;
                float desconto = porcentagem * produto;
                float precoFinal = produto - desconto;

                
                Console.WriteLine("Nome do cliente: " + nome);
                Console.WriteLine("Preço do produto: R$" + produto);
                Console.WriteLine("Desconto dado: R$" + desconto.ToString("0.00"));
                Console.WriteLine("Preço final: R$" + precoFinal.ToString("0.00"));

            } catch {
                Console.WriteLine("Não foi possível :(");
            }

            
        }
    }
}
