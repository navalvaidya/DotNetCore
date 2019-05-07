using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrossCutDemo.Models
{
    public partial class LoggerServiceDBContext : DbContext
    {
        public LoggerServiceDBContext()
        {
        }

        public LoggerServiceDBContext(DbContextOptions<LoggerServiceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblActionLogs> TblActionLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LoggerServiceDB;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<TblActionLogs>(entity =>
            {
                entity.ToTable("tblActionLogs");

                entity.Property(e => e.ActionName).HasMaxLength(50);

                entity.Property(e => e.ControllerName).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(23);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });
        }
    }
}
