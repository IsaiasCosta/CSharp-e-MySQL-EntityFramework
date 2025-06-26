//PessoaDbContextFactory

using entityframework.Conexao;
using entityframework.Entidades;
using entityframework.Servicos;

public class Program
{
    private static void Main(string[] args)
    {
        var pessoaFactory = new PessoaDbContextFactory();

        //contexto
        using (var contexto = pessoaFactory.CreateDbContext(new string[0]))
        {
            var pessoas = new Pessoa[]
            {
                //new Pessoa { Nome = "João", Cidade = "São Paulo", Idade = 30 },
                //new Pessoa { Nome = "Maria", Cidade = "Rio de Janeiro", Idade = 25 },
                //new Pessoa { Nome = "Claucia", Cidade = "Contagem", Idade = 38 },
                //new Pessoa { Nome = "Magda", Cidade = "Bahia", Idade = 48 },
                //new Pessoa { Nome = "Bia", Cidade = "Nova Lima", Idade = 15 },
               // new Pessoa { Nome = "Katia", Cidade = "Londrina", Idade = 92, Codigo =6 }
            };

            foreach (var pessoa in pessoas)
            {
               // PessoaService.Cadastrar(contexto, pessoa);
              //  PessoaService.Atualizar(contexto, pessoa);
            }

            PessoaService.Consultar(contexto);
          //  PessoaService.Deletar(contexto, 2);
        }
    }
}