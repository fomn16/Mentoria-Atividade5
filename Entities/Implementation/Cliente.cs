using Atividade5.Repositories;

namespace Atividade5.Entities.Implementation
{
    public class Cliente
    {
        public List<string> Produtos { get; set; } = new List<string>();
        public int Pagamento { get; set; }

        public Cliente(ProdutoRepository produtoRepository)
        {
            int n = Random.Shared.Next(1, 20);
            for (int i = 0; i < n; i++)
            {
                Produtos.Add(produtoRepository.GetRandomProduto());
            }
            var maxPreco = produtoRepository.GetPrecoProdutoMaisCaro() * n;
            Pagamento = Random.Shared.Next(25, maxPreco + 100);
        }
    }
}
