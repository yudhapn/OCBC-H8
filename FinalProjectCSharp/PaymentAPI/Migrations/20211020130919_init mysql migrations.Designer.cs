﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI.Data;

namespace PaymentAPI.Migrations
{
    [DbContext(typeof(PaymentApiDbContext))]
    [Migration("20211020130919_init mysql migrations")]
    partial class initmysqlmigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PaymentAPI.Models.PaymentDetail", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cardNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("cardOwnerName")
                        .HasColumnType("longtext");

                    b.Property<string>("expirationDate")
                        .HasColumnType("longtext");

                    b.Property<string>("securityCode")
                        .HasColumnType("longtext");

                    b.HasKey("paymentDetailId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
