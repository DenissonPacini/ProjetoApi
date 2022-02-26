using APIRest.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIRest.Infraestrutura.Configuracao
{
    public class CarteirinhaConfiguracao
    {
        public void Configura(EntityTypeBuilder<Carteirinha> builder)
        {
            builder.HasKey(p => p.Id)
                .HasName("Id");

            builder.Property(p => p.Aluno)
                .HasMaxLength(20)
                .HasColumnName("Aluno")
                .HasColumnType("string")
                .IsRequired();

            builder.Property(p => p.SitCarteirinha)
                .HasMaxLength(20)
                .HasColumnName("SitCarteirinha")
                .HasColumnType("string")
                .IsRequired();

            builder.Property(p => p.ViaCarteirinha)
                .HasMaxLength(4)
                .HasColumnName("ViaCarteirinha")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.CodBarrasCarteirinha)
                .HasColumnName("CodBarrasCarteirinha")
                .HasColumnType("string")
                .IsRequired();

            builder.Property(p => p.DTImpressao)
                .HasColumnName("DTImpressao")
                .HasColumnType("DateTime");

            builder.Property(p => p.DTAlteracao)
                .HasColumnName("DTImpressao")
                .HasColumnType("DateTime");
        }
    }
}
