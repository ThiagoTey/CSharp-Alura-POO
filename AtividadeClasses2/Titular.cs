﻿class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
}