
using Microsoft.EntityFrameworkCore; 

namespace FitEvolution.Data.Entities
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        // Adicione outras entidades aqui, como Tópicos, Respostas, Aulas, etc.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Sua_Connection_String");
        }

    }
}
