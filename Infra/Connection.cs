using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Infra
{
    public class Connection: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;"+
                "Database=postgres;" +
                "User Id=postgres;" +
                "Password=postgres;"
            );
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("thesing");
            base.OnModelCreating(modelBuilder);
        }
    }
}
