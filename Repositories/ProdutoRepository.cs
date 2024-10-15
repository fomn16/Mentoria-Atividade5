using Atividade5.Entities.Implementation;

namespace Atividade5.Repositories
{
    public class ProdutoRepository
    {
        private List<Produto> _produtosDisponiveis = new List<Produto>();
        private List<string> _nomesProdutos = new List<string>
        {
            "Coca-cola",
            "Fanta",
            "Guarana",
            "Coxinha",
            "Pastel",
            "Bolo",
            "Pizza",
            "Sorvete",
            "Cachorro-quente",
            "Salada de frutas",
            "Suco de laranja"
        };
        public ProdutoRepository() {
            foreach(var n in _nomesProdutos)
            {
                _produtosDisponiveis.Add(new Produto { Nome = n, Preco = Random.Shared.Next(1, 50)});
            }
        }

        public string GetRandomProduto()
        {
            var index = Random.Shared.Next(_produtosDisponiveis.Count);
            return _produtosDisponiveis[index].Nome;
        }

        // Implemente a função abaixo, que deve utilizar o nome do
        // produto para consultar seu valor em _produtosDisponiveis.

        public int GetValorProduto(string nome)
        {

        }

        public int GetPrecoProdutoMaisCaro()
        {
            return _produtosDisponiveis
                .OrderByDescending(x => x.Preco)
                .First()
                .Preco;
        }
    }
}
