class Conta
{
    public string Titular { get; set; }
    public int IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }
}

class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { 
        get {  return ano; }
        set { if (value > 1960 || value < 2023) ano = value; 
            else { Console.WriteLine("Ano inválido, insira um ano entre 1960 e 2023"); } 
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; }
    public string DescricaoDetalhada => $"Fabricante: {Fabricante} - Modelo : {Modelo} - Ano : {Ano}";
}

class Produto
{
    public string nome;
    public string marca;
    private float preco;
    private float estoque;

    public float Preco {
        get => preco; 
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("Preco não pode ser zero ou negativo");
            } else
            {
                preco = value;
            }
        }
    }
    public float Estoque {
        get => estoque;
        set
        {
            if(value < 0)
            {
                Console.WriteLine("Estoque não pode ser negativo");
            } else
            {
                estoque = value;
            }
        }
    }

    public string Descricao => $"Nome : {this.nome}, Marca {this.marca} - {this.Preco}";

    //Teste de lambda
    public int Somar(int a, int b) => a + b;
}

