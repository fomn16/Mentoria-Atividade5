using Atividade5.Entities.Interfaces;
using Atividade5.Repositories;

namespace Atividade5.Entities.Implementation
{
    public class Caixa : ICaixa
    {
        private int _totalVendas;
        private int _totalTroco;
        private int _totalAtual;

        private ProdutoRepository _produtoRepository;

        public Caixa(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
