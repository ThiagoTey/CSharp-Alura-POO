//Banda queen = new Banda("Queen");

//Album albumQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = true,
//};

//albumQueen.AdicionarMusica(musica1);
//albumQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumQueen);

//musica1.ExibirFichaTecnica();
//albumQueen.ExibirMusicasDoAlbum();
//queen.Exibrdiscografia();

Episodio ep1 = new(1, "Podcast 1", 23);
Console.WriteLine(ep1.Resumo);
ep1.AdicionarConvidados("Jose");
ep1.AdicionarConvidados("Adilson");
Console.WriteLine(ep1.Resumo);