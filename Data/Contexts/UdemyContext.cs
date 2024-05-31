﻿using AspNetEntity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetEntity.Data.Contexts
{
    public class UdemyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; database=UdemyEfCore; Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().ToTable(name: "Categories", schema: "dbo");

            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired(true);
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("product_id");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("product_price");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 3);


            modelBuilder.Entity<Customer>().HasKey(x => new { x.Number,x.Name});
            base.OnModelCreating(modelBuilder);
        }
    }
}
