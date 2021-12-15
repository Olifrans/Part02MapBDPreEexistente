
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Part02MapBDPreEexistente.Negocio;
using System;

namespace MapeandoBDPreEexistente.Dados.Configuration
{
    public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("nvarchar(45)")
                .IsRequired();

            builder
               .Property(a => a.UltimoNome)
               .HasColumnName("last_name")
               .HasColumnType("nvarchar(45)")
               .IsRequired();

            builder
               .Property(a => a.Email)
               .HasColumnName("email")
               .HasColumnType("nvarchar(50)");

            builder
               .Property(a => a.Ativo)
               .HasColumnName("active");

            builder
             .Property<DateTime>("last_update") //Shadow Property
             .HasColumnType("datetime")
             .HasDefaultValueSql("getdate()") //Setando valor em Shadow Property
             .IsRequired();
        }
    }
}
