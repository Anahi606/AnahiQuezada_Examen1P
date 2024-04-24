﻿// <auto-generated />
using System;
using AnahiQuezada_Examen1P.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnahiQuezada_Examen1P.Migrations
{
    [DbContext(typeof(AnahiQuezada_Examen1PContext))]
    [Migration("20240424160313_AnahiQuezada_DB")]
    partial class AnahiQuezada_DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnahiQuezada_Examen1P.Models.AQ_CitaMedica", b =>
                {
                    b.Property<int>("AQ_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AQ_Id"));

                    b.Property<DateTime>("AQ_Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("AQ_Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("AQ_Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("AQ_Urgente")
                        .HasColumnType("bit");

                    b.HasKey("AQ_Id");

                    b.ToTable("AQ_CitaMedica");
                });
#pragma warning restore 612, 618
        }
    }
}
