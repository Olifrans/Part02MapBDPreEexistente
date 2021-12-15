using MapeandoBDPreEexistente.Dados.Configuration;
using Microsoft.EntityFrameworkCore;
using Part02MapBDPreEexistente.Dados.Configuration;
using Part02MapBDPreEexistente.Negocio;


namespace Part02MapBDPreEexistente.Dados
{
    public class AluraFilmesContext : DbContext
    {

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=iti-dev-01;Database=AluraFilmes;Trusted_Connection=true;");
        }

        //quebrando as regras da conversão
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }
    }
}
