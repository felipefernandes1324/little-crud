using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace little_crud
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double valorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

       
        public void adicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void removerProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }



        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
