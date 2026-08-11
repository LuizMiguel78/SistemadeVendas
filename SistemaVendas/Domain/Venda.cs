namespace SistemaVendas.Domain;

public class Venda
{
    public int Id { get; set; }

    public string Cliente { get; set; }

    public List<Produto> Produtos { get; set; } = new();

    public double Total
    {
        get
        {
            return Produtos.Sum(p => p.Preco);
        }
    }
}