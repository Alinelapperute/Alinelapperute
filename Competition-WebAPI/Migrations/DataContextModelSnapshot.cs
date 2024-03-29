﻿// <auto-generated />
using Competition_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Competition_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Competition_WebAPI.Models.Jogos", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Jogosid")
                        .HasColumnType("TEXT");

                    b.Property<int>("ano")
                        .HasColumnType("INTEGER");

                    b.Property<double>("nota")
                        .HasColumnType("REAL");

                    b.Property<string>("titulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("urlImagem")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Jogosid");

                    b.ToTable("Jogo");

                    b.HasData(
                        new
                        {
                            id = "/nintendo-64/the-legend-of-zelda-ocarina-of-time",
                            ano = 1998,
                            nota = 99.900000000000006,
                            titulo = "The Legend of Zelda: Ocarina of Time (N64)",
                            urlImagem = "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/nintendo-64/the-legend-of-zelda-ocarina-of-time"
                        },
                        new
                        {
                            id = "/playstation/tony-hawks-pro-skater-2",
                            ano = 2000,
                            nota = 98.900000000000006,
                            titulo = "Tony Hawk's Pro Skater 2 (PS)",
                            urlImagem = "https://l3-processoseletivo.azurewebsites.net/api/CapaJogo/playstation/tony-hawks-pro-skater-2"
                        });
                });

            modelBuilder.Entity("Competition_WebAPI.Models.Jogos", b =>
                {
                    b.HasOne("Competition_WebAPI.Models.Jogos", null)
                        .WithMany("Jogo")
                        .HasForeignKey("Jogosid");
                });
#pragma warning restore 612, 618
        }
    }
}
