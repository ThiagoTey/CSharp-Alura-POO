class Recomendacao(Usuario usuario)
{
    public Usuario Usuario { get; } = usuario;

    public List<Musica> MusicasRecomendadas { get; }
}