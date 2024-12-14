class Episodio(int ordem, string titulo ,int duracao)
{
    private List<string> convidados = new();
    public int Ordem { get; } = ordem;
    public string Titulo { get; } = titulo;
    public int Duracao { get; } = duracao;
    public string Resumo
    {
        get
        {
            string convidadosText = convidados.Count > 0 ? $"Convidados: {string.Join(", ", convidados)}" : string.Empty;
            return $"Episódio {Ordem}, Titulo: {Titulo}, Duração: {Duracao} minutos, {convidadosText}";
        }
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}