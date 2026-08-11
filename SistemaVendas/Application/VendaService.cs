using SistemaVendas.Domain;

namespace SistemaVendas.Application;

public class VendaService
{
    private readonly List<Venda> vendas = new();

    public void Adicionar(Venda venda)
    {
        venda.Id = vendas.Count + 1;
        vendas.Add(venda);
    }

    public List<Venda> Listar()
    {
        return vendas;
    }
}