using AspNetEntity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetEntity.Data.Contexts
{
    public class UdemyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; database=UdemyEfCore; Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
