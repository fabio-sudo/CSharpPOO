//Adicionar com construtor
using ConsoleAppOrientacaoObjeto.Controller;

Pessoa pessoa1 = new Pessoa(1, "Fábio", 32);
Pessoa pessoa2 = new Pessoa(2, "Fernanda", 27);


//Aducionar no objeto
Pessoa pessoa3 = new Pessoa();
pessoa3.Id = 3;
pessoa3.Nome = "Lucas";
pessoa3.Idade = 25;

//Aducionar quando instanciar o objeto
Pessoa pessoa4 = new Pessoa
{
    Id = 4,
    Nome = "Bruna",
    Idade = 16
};


//Instaciando classe
PessoaController controller = new PessoaController();


//Adicionando 
controller.Adicionar(pessoa1);
controller.Adicionar(pessoa2);
controller.Adicionar(pessoa3);
controller.Adicionar(pessoa4);


//Apresenta pessoa
controller.Apresentar(pessoa1);

//Exibir Pessoas da lista por nome
controller.BuscarPorNome("");

//Salvar Json
controller.AddJson();
controller.LerJson();