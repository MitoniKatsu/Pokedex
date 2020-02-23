using Data.Entities;
using Data.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Pokemon = Data.Entities.Pokemon;
using Type = Data.Entities.Type;

namespace Data
{
    public class PokedexDbContext : DbContext, IPokedexDbContext
    {
        public PokedexDbContext()
        {
        }

        public PokedexDbContext(DbContextOptions<PokedexDbContext> options) : base(options)
        {
        }

        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonSpecies> PokemonSpecies { get; set; }
        public DbSet<Type> Type { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = Environment.GetEnvironmentVariable("Connection_String");
            if (!string.IsNullOrEmpty(connectionString))
            {
                builder.UseSqlServer(connectionString);
                return;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Entities.Pokemon>(e =>
            {
                e.ToTable("Pokemon");
                e.HasKey(k => k.PokemonID);

                e.Property(p => p.PokemonID)
                .UseIdentityColumn();

                e.Property(p => p.SpeciesID)
                .IsRequired();

                e.Property(p => p.PokemonName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode();

                e.HasOne(o => o.Species)
                    .WithOne()
                    .HasForeignKey<Entities.Pokemon>(k => k.SpeciesID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<PokemonSpecies>(e =>
            {
                e.ToTable("PokemonSpecies");
                e.HasKey(k => k.SpeciesID);

                e.Property(p => p.SpeciesName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode();

                e.Property(p => p.SpeciesID)
                .ValueGeneratedNever();

                e.Property(p => p.PrimaryTypeID)
                .IsRequired();

                e.Property(p => p.SecondaryTypeID)
                .IsRequired(false);

                e.Property(p => p.SpeciesDescription)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode();

                e.HasOne(o => o.PrimaryType)
                .WithOne()
                .HasForeignKey<PokemonSpecies>(k => k.PrimaryTypeID)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(o => o.SecondaryType)
                .WithOne()
                .HasForeignKey<PokemonSpecies>(k => k.SecondaryTypeID)
                .OnDelete(DeleteBehavior.Restrict);

                //seed data
                //e.HasData(PokemonSeedParser.GetSpeciesSeedList());
            });

            builder.Entity<Type>(e =>
            {
                e.ToTable("Type");
                e.HasKey(k => k.TypeID);

                e.Property(p => p.TypeName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

                //seed data
                //e.HasData(PokemonSeedParser.GetTypeSeedList());
            });
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
