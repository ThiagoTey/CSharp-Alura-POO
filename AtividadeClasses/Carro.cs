class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value > 1960 || value < 2023) ano = value;
            else { Console.WriteLine("Ano inválido, insira um ano entre 1960 e 2023"); }
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; }
    public string DescricaoDetalhada => $"Fabricante: {Fabricante} - Modelo : {Modelo} - Ano : {Ano}";
}