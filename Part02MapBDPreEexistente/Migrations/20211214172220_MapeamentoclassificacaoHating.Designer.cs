﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Part02MapBDPreEexistente.Dados;

namespace Part02MapBDPreEexistente.Migrations
{
    [DbContext(typeof(AluraFilmesContext))]
    [Migration("20211214172220_MapeamentoclassificacaoHating")]
    partial class MapeamentoclassificacaoHating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("actor_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasColumnName("first_name");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasAlternateKey("PrimeiroNome", "UltimoNome");

                    b.HasIndex("UltimoNome")
                        .HasDatabaseName("idx_actor_last_name");

                    b.ToTable("actor");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("film_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoLancamentoFilme")
                        .HasColumnType("varchar(4)")
                        .HasColumnName("release_year");

                    b.Property<string>("Clasificacao")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rating");

                    b.Property<string>("DescricaoFilme")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<short>("DuracaaoFilme")
                        .HasColumnType("smallint")
                        .HasColumnName("length");

                    b.Property<string>("TituloFilme")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("title");

                    b.Property<byte>("language_id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<byte?>("original_language_id")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("language_id");

                    b.HasIndex("original_language_id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.FilmeAtor", b =>
                {
                    b.Property<int>("film_id")
                        .HasColumnType("int");

                    b.Property<int>("actor_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("film_id", "actor_id");

                    b.HasIndex("actor_id");

                    b.ToTable("film_actor");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Idioma", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnName("language_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("char(20)")
                        .HasColumnName("name");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("language");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Filme", b =>
                {
                    b.HasOne("Part02MapBDPreEexistente.Negocio.Idioma", "IdiomaFalado")
                        .WithMany("FilmesFalados")
                        .HasForeignKey("language_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Part02MapBDPreEexistente.Negocio.Idioma", "IdiomaOriginal")
                        .WithMany("FilmeOriginal")
                        .HasForeignKey("original_language_id");

                    b.Navigation("IdiomaFalado");

                    b.Navigation("IdiomaOriginal");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.FilmeAtor", b =>
                {
                    b.HasOne("Part02MapBDPreEexistente.Negocio.Ator", "Ator")
                        .WithMany("Filmografia")
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Part02MapBDPreEexistente.Negocio.Filme", "Filme")
                        .WithMany("Atores")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ator");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Ator", b =>
                {
                    b.Navigation("Filmografia");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Filme", b =>
                {
                    b.Navigation("Atores");
                });

            modelBuilder.Entity("Part02MapBDPreEexistente.Negocio.Idioma", b =>
                {
                    b.Navigation("FilmeOriginal");

                    b.Navigation("FilmesFalados");
                });
#pragma warning restore 612, 618
        }
    }
}
