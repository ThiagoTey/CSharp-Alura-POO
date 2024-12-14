class ReprodutorMusica
{
    private int nMusicaReproduzindo = 0;
    public bool Reproduzindo { get; private set; } 
    public Playlist Playlist { get; set; }
    public Musica MusicaReproduzindo { get; private set; }
    public int Volume { get; private set; } = 50;

    public void Reproduzir()
    {
        if (Playlist != null)
        {
            Reproduzindo = true;
            MusicaReproduzindo = Playlist.Musicas[nMusicaReproduzindo];
        } else
        {
            Console.WriteLine("Adicione uma playlist");
        }
    }
    public void Pausar()
    {
        Reproduzindo = false;
    }

    public void Avancar()
    {
        if (Playlist.Musicas.Count > nMusicaReproduzindo) {
            nMusicaReproduzindo++;
        } else
        {
            nMusicaReproduzindo = 0;
        }
    }

    public void Retroceder()
    {
        if (nMusicaReproduzindo > 0)
        {
            nMusicaReproduzindo--;
        }
    }

    public void AumentarVolume()
    {
        if (Volume < 100) {
            Volume += 5;
        } 
    }

    public void DiminuirVolume()
    {
        if (Volume > 0)
        {
            Volume -= 5;
        }
    }

    public void DefinirVolume(int volume)
    {
        Volume = Math.Clamp(volume, 0, 100);
    }
}