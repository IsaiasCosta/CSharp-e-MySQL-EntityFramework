using entityframework.Contextos;
using entityframework.Entidades;

namespace entityframework.Servicos
{
    public class PessoaService
    {
        public static void Cadastrar(PessoaDbContext context, Pessoa pessoa)
        {
            //Adiconar ao DbSet
            //INSERT INTO pessoas (nome, ciade, idade) VALUES(nome, cidade,idade)
            context.Pessoas.Add(pessoa);

            //Salvar
            context.SaveChanges();

            //retorno
            Console.WriteLine($" Pessoa cadastrada com sucesso!");
        }
        public static void Consultar(PessoaDbContext context)
        {
            // Consultar 
            //SELECT * FROM pessoas
            //var pessoas = context.Pessoas.ToList();
         
            var pessoas = context.Pessoas
                .OrderByDescending(p=>p.Cidade)
                .ToList();

            //if (!pessoas.Any())
            //{
               
            //        Console.WriteLine($"Nenhuma pessoa encontrada sem a letra {letra} no nome.");
            //}else

               // Exibir os dados
                Console.WriteLine("Pessoas Cadastradas:");

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Código: {pessoa.Codigo} - Nome: {pessoa.Nome} - Cidade: {pessoa.Cidade} - Idade: {pessoa.Idade}");

            }


        }
        public static void Atualizar(PessoaDbContext context, Pessoa pessoaAtualizada)
        {
            //verificar se existe a PESSOA
            var existePessoa = context.Pessoas.Find(pessoaAtualizada.Codigo);

            //condição
            if (existePessoa != null)
            {
                //Atualiza os dados

                //UPDADE pessoas SET nome=nome, cidade=cidade, idade=idade WHERE codigo=codigo;

                existePessoa.Nome = pessoaAtualizada.Nome;
                existePessoa.Cidade = pessoaAtualizada.Cidade;
                existePessoa.Idade = pessoaAtualizada.Idade;

                //Salva
                context.SaveChanges();

                //retorno

                Console.WriteLine("Pessoa Atualizada com sucesso...");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada , registronão alterado ");
            }

        }
        public static void Deletar(PessoaDbContext context, int codigo)
        {
            //Encotrat a Pessoa
            var pessoa = context.Pessoas.Find(codigo);

            //Verificar

            if (pessoa != null)
            {
                //Remove do DbSet
                //DELETE FROM pessoas WHERE  codigo = codigo
                context.Pessoas.Remove(pessoa);

                //Salvar
                context.SaveChanges();

                //Retorno
                Console.WriteLine($"Registro da Pessoa apagado com sucesso");
            }
            else
            {
                Console.WriteLine($"Código {codigo} não encontrado");
            }
        }
    }
}
