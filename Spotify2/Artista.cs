class Artista(string nome)
{
    public string Nome { get; set; } = nome;
    public string Biografia { get; set; }
    public List<Album> Albums { get; set; }
}