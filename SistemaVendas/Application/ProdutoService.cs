using SistemaVendas.Domain;

namespace SistemaVendas.Application;

public class ProdutoService
{
    private readonly List<Produto> produtos = new();

    public void Adicionar(Produto produto)
    {
        produto.Id = produtos.Count + 1;

        produtos.Add(produto);
    }

    public List<Produto> Listar()
    {
        return produtos;
    }
}