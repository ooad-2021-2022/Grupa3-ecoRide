using ecoRide.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecoRide.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GoldenAgePogodnosti> GoldenAgePogodnosti { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<Izvjestaj> Izvjestaj { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<Recenzije> Recenzije { get; set; }
        public DbSet<VrstaPlacanja> VrstaPlacanja { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GoldenAgePogodnosti>().ToTable("GoldenAgePogodnosti");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");
            modelBuilder.Entity<Izvjestaj>().ToTable("Izvjestaj");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Lokacija>().ToTable("Lokacija");
            modelBuilder.Entity<Recenzije>().ToTable("Recenzije");
            modelBuilder.Entity<VrstaPlacanja>().ToTable("VrstaPlacanja");
            base.OnModelCreating(modelBuilder);
        }
    }

}