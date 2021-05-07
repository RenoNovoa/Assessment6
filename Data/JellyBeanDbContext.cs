using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mock_Assessment_6.Data
{
    public partial class JellyBeanDbContext : DbContext
    {
        public JellyBeanDbContext()
        {
        }

        public JellyBeanDbContext(DbContextOptions<JellyBeanDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JellyBean> JellyBean { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:JellyBeanDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JellyBean>(entity =>
            {
                entity.Property(e => e.Style).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
