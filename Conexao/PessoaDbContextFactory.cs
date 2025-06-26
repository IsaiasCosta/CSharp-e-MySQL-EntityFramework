

using entityframework.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace entityframework.Conexao
{
    // Contexto de banco de dados
    public class PessoaDbContextFactory : IDesignTimeDbContextFactory<PessoaDbContext>
    {
        //Configuração da conexão do banco de dados

        private readonly string _server = "localhost";
        private readonly string _database = "base_ef";
        private readonly string _user = "root";
        private readonly string _password = "Admin";
        public PessoaDbContext CreateDbContext(string[] args)
        {
            var connectString = $"Server={_server};Database={_database};User={_user};Password={_password};";
            var optionsBuilder = new DbContextOptionsBuilder<PessoaDbContext>();
            optionsBuilder.UseMySQL(connectString); //Configura o banco com o contexto

            //Retorna a instancia do contexto do banco de dados configurado
            return new PessoaDbContext(optionsBuilder.Options);
        }

    }
}
