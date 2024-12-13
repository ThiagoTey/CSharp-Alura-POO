class Album(string nome, Artista artista)
{
    public string Nome { get; } = nome;
    public Artista Artista { get; set; } = artista;
    public List<Musica> Musicas { get; set; }
}