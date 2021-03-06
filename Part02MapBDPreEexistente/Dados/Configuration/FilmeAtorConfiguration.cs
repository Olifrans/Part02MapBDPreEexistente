using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Part02MapBDPreEexistente.Negocio;
using System;

namespace Part02MapBDPreEexistente.Dados.Configuration
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            //Fimes
           builder.ToTable("film_actor");

            builder.Property<int>("actor_id").IsRequired(); //shadow property
            builder.Property<int>("film_id").IsRequired(); //shadow property

            builder.Property<DateTime>("last_update") //Shadow Property
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()") //Vlor padão  Shadow Property
              .IsRequired();

            builder.HasKey("film_id", "actor_id");

            //conf de relacionamento chave estrangeira
            builder
                .HasOne(fa => fa.Filme)
                .WithMany(f => f.Atores)
                .HasForeignKey("film_id");

            //conf de relacionamento chave estrangeira
            builder
                .HasOne(fa => fa.Ator)
                .WithMany(f => f.Filmografia)
                .HasForeignKey("actor_id");
        }
    }
}
