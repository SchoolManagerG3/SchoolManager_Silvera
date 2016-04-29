using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace WebApplication3.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Elev> Elever { get; set; }
        public DbSet<Klass> Klasser { get; set; }
        public DbSet<Administratör> Administratörer { get; set; }
        public DbSet<Kurs> Kurser { get; set; }
        public DbSet<Lärare> Lärare { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Elev>().ToTable("Elever");
            modelBuilder.Entity<Klass>().ToTable("Klasser");
            modelBuilder.Entity<Administratör>().ToTable("Administratörer");
            modelBuilder.Entity<Kurs>().ToTable("Kurser");
            modelBuilder.Entity<Lärare>().ToTable("Lärare");


        }
    }
}
