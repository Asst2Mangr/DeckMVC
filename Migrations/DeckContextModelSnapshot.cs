﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

#nullable disable

namespace Project2.Migrations
{
    [DbContext(typeof(DeckContext))]
    partial class DeckContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project2.Models.Deck", b =>
                {
                    b.Property<int>("DeckID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeckID"));

                    b.Property<int>("DeckCount")
                        .HasColumnType("int");

                    b.Property<string>("DeckName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeckID");

                    b.ToTable("Decks");

                    b.HasData(
                        new
                        {
                            DeckID = 1,
                            DeckCount = 78,
                            DeckName = "Rider-Waite Tarot"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}