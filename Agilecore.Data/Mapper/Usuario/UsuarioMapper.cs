using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class UsuarioMapper : EntityTypeConfiguration<UsuarioDto>
    {
        public UsuarioMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.NOME).IsRequired().HasMaxLength(100);
            this.Property(_ => _.EMAIL).IsRequired().HasMaxLength(100);
            this.Property(_ => _.SENHA).IsRequired().HasMaxLength(50);
            this.Property(_ => _.CPF).IsRequired().HasMaxLength(30);
            this.Property(_ => _.DT_NASCIMENTO).IsRequired();
            this.Property(_ => _.DT_CADASTRO).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("USUARIO", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_USUARIO");
            this.Property(_ => _.NOME).HasColumnName("NOME");
            this.Property(_ => _.EMAIL).HasColumnName("EMAIL");
            this.Property(_ => _.SENHA).HasColumnName("SENHA");
            this.Property(_ => _.CPF).HasColumnName("CPF");
            this.Property(_ => _.DT_NASCIMENTO).HasColumnName("DT_NASCIMENTO");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

