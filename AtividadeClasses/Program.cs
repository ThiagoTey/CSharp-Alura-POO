
void AtividadeConta()
{
    Titular titular1 = new Titular();
    Conta conta1 = new Conta();

    titular1.Nome = "Adamiltom";

    conta1.Titular = titular1;
    conta1.Saldo = 500;
    conta1.Agencia = "234";

    conta1.Consulta();
}

//AtividadeConta();

void AtividadeProduto()
{
    Produto produto1 = new Produto();
    Produto produto2 = new Produto();

    produto1.Nome = "Caneta";
    produto1.Marca = "Aquela la";
    produto1.Preco = 25;
    produto1.Estoque = 10;

    produto2.Nome = "Mouse";
    produto2.Marca = "Aquela outra";
    produto2.Preco = 45;
    produto2.Estoque = 5;

    EstoqueProdutos estoque1 = new EstoqueProdutos();
    estoque1.AdicionarProduto(produto1);
    estoque1.AdicionarProduto(produto2);
    estoque1.Nome = "matriz";

    estoque1.ExibirEstoque();
}

AtividadeProduto();