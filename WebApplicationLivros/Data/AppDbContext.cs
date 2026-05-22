using Microsoft.EntityFrameworkCore;
using WebApplicationLivros.Models.Autor;
using WebApplicationLivros.Models.Livro;

namespace WebApplicationLivros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
