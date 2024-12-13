class Usuario(string nome, string email, string senha)
{
    public string Nome { get; set; } = nome;
    public string Email { get; } = email;
    private string Senha { get; set; } = senha;
    public List<Musica>? Historico { get; set; }
    public List<Playlist>? Playlists { get; set; }
    public List<AvaliacaoMusica>? Avaliacoes { get; set; }

}