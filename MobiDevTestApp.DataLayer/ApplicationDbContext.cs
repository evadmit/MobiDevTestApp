using System;
using Microsoft.EntityFrameworkCore;
using MobiDevTestApp.DataLayer.Entities;

namespace MobiDevTestApp.DataLayer
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mobidevtest;Username=postgres;Password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
            .HasOne<Measurment>(s => s.Measurment)
            .WithMany(g => g.Ingredients)
            .HasForeignKey(s => s.MeasurmentId);

            modelBuilder.Entity<CocktailIngredient>().HasKey(ci => new { ci.CocktailId, ci.IngredientId });

        }

        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measurment> Measurments { get; set; }
        public DbSet<CocktailIngredient> CocktailIngredients { get; set; }
    }
}
