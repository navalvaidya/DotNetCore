using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrossCutDemo.Models
{
    public partial class DeloitteDBContext : DbContext
    {
        public DeloitteDBContext()
        {
        }

        public DeloitteDBContext(DbContextOptions<DeloitteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DeloitteDB;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.LaunchDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });
        }
    }
}
