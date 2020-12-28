using Microsoft.EntityFrameworkCore;

namespace EstudoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=EstudoMVC; Integrated Security=True");
        }
    }
}