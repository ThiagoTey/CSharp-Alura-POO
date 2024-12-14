class Notificacao(Usuario usuario)
{
    public Usuario Usuario { get; } = usuario;
    public string MsgNotificacao { get; set; }
}