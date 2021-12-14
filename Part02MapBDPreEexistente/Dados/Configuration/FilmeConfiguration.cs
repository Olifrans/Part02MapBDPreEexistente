using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Part02MapBDPreEexistente.Negocio;
using System;

namespace Part02MapBDPreEexistente.Dados.Configuration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            //Fimes
           builder
                 .ToTable("film");

           builder
                .Property(f => f.Id)
                .HasColumnName("film_id");

           builder
                .Property(a => a.TituloFilme)
                .HasColumnName("title")
                .HasColumnType("nvarchar(255)")
                .IsRequired();

           builder
               .Property(a => a.DescricaoFilme)
               .HasColumnName("description")
               .HasColumnType("text")
               .IsRequired();


           builder
              .Property(a => a.AnoLancamentoFilme)
              .HasColumnName("release_year")
              .HasColumnType("varchar(4)");


           builder
              .Property(a => a.DuracaaoFilme)
              .HasColumnName("length");


           builder
              .Property<DateTime>("last_update") //Shadow Property
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()") //Setando um valor padão  para Property Shadow Property
              .IsRequired();



            //Shadow property FK idoma falado
            builder.Property<byte>("language_id");

            //Shadow property FK idoma original
            builder.Property<byte?>("original_language_id");

            //conf de relacionamento idoma falado
            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("language_id");

            //conf de relacionamento idoma original
            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmeOriginal)
                .HasForeignKey("original_language_id");


            //Mapeamento de classificação
            builder
                .Property(f => f.Clasificacao)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)");

        }
    }
}
