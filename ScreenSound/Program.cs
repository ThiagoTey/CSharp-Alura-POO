Musica musica1 = new Musica();
musica1.nome = "Dead memories";
musica1.artista = "Slipknot";
musica1.duracao = 300;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.nome = "In The End";
musica2.artista = "Linkin Park";
musica2.duracao = 323;
musica2.Disponivel = false;

musica2.ExibirFichaTecnica();