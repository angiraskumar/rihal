
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CurdOperation.Repo.Enitity
{
    public class SqlLiteDBContext:DbContext
    {
        public DbSet<Classes> Classes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=\\RihalDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Classes>().ToTable("Classes");
            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.ClassId);
                entity.HasIndex(e => e.ClassName).IsUnique();
                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
