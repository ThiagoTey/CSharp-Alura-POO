class Compartilhamento(Usuario usuario)
{
    public Usuario Usuario { get; } = usuario;
    public string LinkCompartilhado { get; set; }
}