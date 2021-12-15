using MapeandoBDPreEexistente.Dados.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Part02MapBDPreEexistente.Negocio;
using System;

namespace Part02MapBDPreEexistente.Dados.Configuration
{
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //Funcionario
            base.Configure(builder);

            builder.ToTable("staff");

            builder
                .Property(a => a.Id)
                .HasColumnName("staff_id");            

            builder
               .Property(a => a.UsuarioLogin)
               .HasColumnName("username")
               .HasColumnType("nvarchar(16)")
               .IsRequired();

            builder
               .Property(a => a.UsuarioSenha)
               .HasColumnName("password")
               .HasColumnType("nvarchar(40)");
        }
    }
}