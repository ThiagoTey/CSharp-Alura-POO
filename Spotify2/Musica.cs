class Musica(string nome, Artista artista, GeneroMusical genero, Album album)
{
    public string Nome { get; set; } = nome;
    public Artista Artista { get; set; } = artista;
    public GeneroMusical Genero { get; } = genero;
    public Album Album { get; } = album;
    public List<AvaliacaoMusica> Avaliacoes { get; set; }
}