
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Part02MapBDPreEexistente.Negocio;
using System;

namespace MapeandoBDPreEexistente.Dados.Configuration
{
    public class ClienteConfiguration : PessoaConfiguration<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Cliente
            base.Configure(builder);

            builder.ToTable("customer");

            builder
                .Property(a => a.Id)
                .HasColumnName("customer_id");

            builder
              .Property<DateTime>("create_date") //Shadow Property
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()") //Setando valor em Shadow Property
              .IsRequired();
        }       
    }
}
