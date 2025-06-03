using Newtonsoft.Json;

namespace ConsoleAppOrientacaoObjeto.Controller
{
    public class PessoaController
    {
            List<Pessoa> pessoaList;


            //Inicializando lista no construtor
            public PessoaController()
            {
                pessoaList = new List<Pessoa>();
            }

            //Metodo Adicionar
            public void Adicionar(Pessoa pessoa)
            {
                pessoaList.Add(pessoa);
            }

            //Metodo Apresentar
            public void Apresentar(Pessoa pessoa)
            {
                Console.WriteLine(
                    $"Id: {pessoa.Id}\n" +
                    $"Nome: {pessoa.Nome}\n" +
                    $"Idae: {pessoa.Idade} \n");
            }

            //Busca por nome e retorna lista se necessário
            public void BuscarPorNome(string nome)
            {
                if (pessoaList.Count > 0)
                {
                    var pessoas = pessoaList.Where(p => p.Nome.Contains(nome)).ToList();

                    if (pessoas.Count > 0)
                    {
                        foreach (var pessoa in pessoas)
                        {
                            Apresentar(pessoa);
                        }
                    }


                }
                else { Console.WriteLine("Nenhuma pessoa adicionada"); }
            }


            //Criar e ler arquivo .json
            public void AddJson()
            {
                if (pessoaList.Count > 0)
                {
                    var json = JsonConvert.SerializeObject(pessoaList, Formatting.Indented);
                    // Salva o arquivo
                    File.WriteAllText("C:\\Users\\Admin\\source\\repos\\ConsoleAppOrientacaoObjeto\\ConsoleAppOrientacaoObjeto\\Arquivo\\Pessoa.json", json);

                }
            }

            public void LerJson()
            {
                // Caminho completo do arquivo JSON
                string caminhoArquivo = "C:\\Users\\Admin\\source\\repos\\ConsoleAppOrientacaoObjeto\\ConsoleAppOrientacaoObjeto\\Arquivo\\Pessoa.json";

                // Ler o conteúdo do arquivo
                string json = File.ReadAllText(caminhoArquivo);

                // Desserializar o JSON para lista de Pessoa
                List<Pessoa> pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(json);

                // Exibir cada pessoa no console
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
                }

            }
        }
}
