Musica musica1 = new Musica();
musica1.Nome = "Dead memories";
musica1.Artista = "Slipknot";
musica1.Duracao = 300;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "In The End";
musica2.Artista = "Linkin Park";
musica2.Duracao = 323;
musica2.Disponivel = false;

musica2.ExibirFichaTecnica();