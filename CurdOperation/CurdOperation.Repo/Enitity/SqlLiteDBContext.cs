
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CurdOperation.Repo.Enitity
{
    public class SqlLiteDBContext:DbContext
    {
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

          // var dataSource = Path.Combine("..//..//", "StudentDB.db");
          //  optionsBuilder.UseSqlite($"Data Source={dataSource};");

            optionsBuilder.UseSqlite("Filename=StudentDB.db", options =>
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

            // Map table names
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);
                entity.HasIndex(e => e.CountryName).IsUnique();
                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
            });


            // Map table names
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId);
                entity.HasIndex(e => e.StudentName).IsUnique();
                entity.Property(e => e.CountryId);
                entity.Property(e => e.ClassId);
                entity.Property(e => e.CreateDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("CURRENT_TIMESTAMP"); ;
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
