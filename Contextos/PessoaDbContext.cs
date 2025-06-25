using entityframework.Entidades;
using Microsoft.EntityFrameworkCore;

namespace entityframework.Contextos
{
    //Defeinir o contexto de dados
    public class PessoaDbContext : DbContext
    {
        //Construtor
        public PessoaDbContext(DbContextOptions<PessoaDbContext> options) : base(options) { }

        //Reperentar a tabela Pessoas no Banco
        public DbSet<Pessoa> Pessoas { get; set; }

        //Configurar o modelo de dados, incluir primary key 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Define a propriedade'Codigop'como chave primaria

            modelBuilder.Entity<Pessoa>().HasKey(i => i.Codigo);
        }
    }
}
