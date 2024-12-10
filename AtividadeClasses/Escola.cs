class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; }
}

class Professor
{
    public string Nome { get; set; }
    public List<string> Disciplinas { get; set; }
}

class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get;set; }
}