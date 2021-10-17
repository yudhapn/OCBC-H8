﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesApi.Data;

namespace MoviesApi.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20211017151251_Init Migrations")]
    partial class InitMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MoviesApi.Models.MovieItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("adult")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("overview")
                        .HasColumnType("longtext");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.Property<double>("voteAverage")
                        .HasColumnType("double");

                    b.Property<int>("voteCount")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}