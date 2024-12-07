class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private float preco;
    private float estoque;

    public float Preco
    {
        get => preco;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Preco não pode ser zero ou negativo");
            }
            else
            {
                preco = value;
            }
        }
    }
    public float Estoque
    {
        get => estoque;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Estoque não pode ser negativo");
            }
            else
            {
                estoque = value;
            }
        }
    }

    public string Descricao => $"Nome : {this.Nome}, Marca: {this.Marca} - R${this.Preco}";

    //Teste de lambda
    public int Somar(int a, int b) => a + b;
}

class EstoqueProdutos
{
    List<Produto> produtos = new List<Produto>();
    public string Nome { get; set; }
    public void AdicionarProduto(Produto Produto)
    {
        produtos.Add(Produto);
        Console.WriteLine("Produto adicionado com sucesso");
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produtos no estoque : {Nome}");
        foreach(Produto produto in produtos)
        {
            Console.WriteLine(produto.Descricao);
        }
    }
}