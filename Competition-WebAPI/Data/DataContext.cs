using System.Collections.Generic;
using Competition_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Competition_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Jogos> Jogo { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Jogos>()
                .HasKey(AD => new { AD.id });

            builder.Entity<Jogos>()
                .HasData(new List<Jogos>(){
                    new Jogos("/nintendo-64/the-legend-of-zelda-ocarina-of-time",
                    "The Legend of Zelda: Ocarina of Time (N64)",
                    99.9,
                    1998,
                    "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/nintendo-64/the-legend-of-zelda-ocarina-of-time"),

                    new Jogos("/playstation/tony-hawks-pro-skater-2",
                    "Tony Hawk's Pro Skater 2 (PS)",
                    98.9,
                    2000,
                    "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/playstation/tony-hawks-pro-skater-2"),

                });

        }

    }
}
