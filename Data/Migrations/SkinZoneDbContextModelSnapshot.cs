﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkinZoneAppWeb.Data;

#nullable disable

namespace SkinZoneAppWeb.Data.Migrations
{
    [DbContext(typeof(SkinZoneDbContext))]
    partial class SkinZoneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SkinZoneAppWeb.Models.Skin", b =>
                {
                    b.Property<int>("SkinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkinId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRetirada")
                        .HasColumnType("datetime2");

                    b.Property<int>("Desgaste")
                        .HasColumnType("int");

                    b.Property<bool>("DisponivelParaRetirada")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.Property<int>("TradeLock")
                        .HasColumnType("int");

                    b.HasKey("SkinId");

                    b.HasIndex("TipoId");

                    b.ToTable("Skin");
                });

            modelBuilder.Entity("SkinZoneAppWeb.Models.Tipo", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoId");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("SkinZoneAppWeb.Models.Skin", b =>
                {
                    b.HasOne("SkinZoneAppWeb.Models.Tipo", null)
                        .WithMany("Skins")
                        .HasForeignKey("TipoId");
                });

            modelBuilder.Entity("SkinZoneAppWeb.Models.Tipo", b =>
                {
                    b.Navigation("Skins");
                });
#pragma warning restore 612, 618
        }
    }
}
