
using System.Security.Cryptography.X509Certificates;

class ProdutoRestaurante
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
class Restaurante
{
    public List<Mesa> Mesas { get; set; }
    public Cardapio Cardapio { get; set; }
}

class Mesa
{
    public int NumeroMesa { get; set; }
    public bool Resenvada { get; set; }
    public List<Pedido> Pedidos { get; set; }
}

class Pedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

}

class Cardapio
{
    public List<ProdutoRestaurante> Produtos { get; set; }
}