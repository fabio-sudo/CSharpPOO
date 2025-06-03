public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    //Construtor
    public Pessoa() { }

    public Pessoa(int id, string nome, int idade)
    {

        Id = id;
        Nome = nome;
        Idade = idade;
    }
}

