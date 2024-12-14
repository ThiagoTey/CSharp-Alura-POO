class Podcast(string nome, string host)
{
    public string Nome { get; } = nome;
    public string Host { get; } = host;
    public List<Episodio> Episodios { get; private set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome Podcast: {Nome}, Host: {Host}");
        Console.WriteLine("Episódios :");
        foreach (Episodio episodio in Episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}