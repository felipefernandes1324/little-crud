using System;
using System.Globalization;

namespace little_crud
{
    class Program
    {
        static void Main(string[] args)
        {
        Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.adicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque");
            int mqte = int.Parse(Console.ReadLine());
            p.removerProdutos(mqte);
            Console.WriteLine("Dados atualizados: " + p);
            
            
        }
    }
}
