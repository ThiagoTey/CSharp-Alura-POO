class Titular
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
}

class Conta
{
    public Titular Titular { get; set; }
    public string Agencia { get; set; }
    public float Limite { get; set; }
    public int IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }

    public void Consulta()
    {
        Console.WriteLine($"Dados bancários de : {Titular.Nome}");
        Console.WriteLine($"Agencia: {Agencia} - Saldo : {Saldo} - Limite : {Limite}");
    }
}
