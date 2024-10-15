using Atividade5.Repositories;

namespace Atividade5.Entities.Interfaces
{
    public interface ICaixa
    {        
        // - Implementar função que "escaneie" (percorra) uma lista de produtos,
        //   salvando o valor total dos produtos na variável _totalAtual.
        // - A função deve imprimir o total da compra na tela
        // - Além disso, a função deve imprimir, para cada tipo de produto, Seu
        //   valor unitário, e a quantidade comprada.
        public void EscanearProdutos(List<string> produtos);

        // - Implementar função que recebe o pagamento do cliente e
        //   verifica se foi entregue dinheiro suficiente para pagar a quantidade
        //   presente na variável _totalAtual.
        // - Se não for suficiente, deve imprimir a mensagem de erro na tela.
        // - Se for suficiente, deve calcular e imprimir o troco, e deve somar o valor
        //   da compra em _totalVendas, e o total de troco em _totalTroco
        public void ProcessarPagamento(int recebido);

        // Implementar função que imprime o total de vendas feitas
        // (presente em _totalVendas) e o total de troco dado (_totalTroco).
        public void RelatorioDiario();
    }
}
