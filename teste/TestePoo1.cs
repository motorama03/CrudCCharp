using System;

public class TestePoo1
{
    private string nome;
    private int idade;

    public TestePoo1(int idade, string nome)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void setNome(string nome)
    {
        nome = nome;
    }
    public string getNome()
    {
        return nome;
    }
    public void setIdade(int idade)
    {
        idade = idade;
    }
    public int getIdade()
    {
        return idade;
    }

    public String retornaValores(Teste teste)
    {
        String pessoa = ("O " + nome + " tem " + idade + " anos de idade");
        Console.Write(teste.toString());
        return pessoa;
    }
}
