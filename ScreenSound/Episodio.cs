class Episodio(int ordem, int duracao, string titulo)
{
    private string convidados = "";
    public int Ordem { get; } = ordem;
    public int Duracao { get; } = duracao;
    public string Titulo { get; } = titulo;
    public string Resumo
    {
        get => $"Episódio {Ordem}, Duração: {Duracao} minutos, Convidados: {convidados}";
    }

    public void AdicionarConvidados(string convidado)
    {
        if (!string.IsNullOrEmpty(convidados))
        { 
            convidados += ", ";
        }
        convidados += convidado;
    }
}