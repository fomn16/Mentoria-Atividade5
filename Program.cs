using Atividade5.Entities.Implementation;
using Atividade5.Entities.Interfaces;
using Atividade5.Repositories;

// Recomendo que tentem entender todo o código desta atividade,
// que trata de todos os temas que conversamos até então. No entanto,
// o entendimento geral não é necessário para completar a atividade,
// sendo possível focar apenas em completar os seguintes passos:

// 1) Completar a função GetValorProduto presente em ProdutoRepository.cs

// 2) Implementar, em Caixa.cs, os três métodos da interface ICaixa.cs

// 3) Executar o programa sem erros.

var fila = new Queue<Cliente>();
var tamanhoFila = Random.Shared.Next(1, 20);
var repository = new ProdutoRepository();

int i;
for (i = 0; i < tamanhoFila; i++)
{
    fila.Enqueue(new Cliente(repository));
}

i = 0;

ICaixa caixa = new Caixa(repository);
while (fila.Any())
{
    var clienteAtual = fila.Dequeue();
    Console.WriteLine($"Cliente {i++}:");
    caixa.EscanearProdutos(clienteAtual.Produtos);
    Thread.Sleep(3000);
    caixa.ProcessarPagamento(clienteAtual.Pagamento);
    Thread.Sleep(3000);
}

caixa.RelatorioDiario();