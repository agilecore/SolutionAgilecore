using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class ClienteMapper : EntityTypeConfiguration<ClienteDto>
    {
        public ClienteMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.NOME).IsRequired().HasMaxLength(100);
            this.Property(_ => _.EMAIL).IsRequired().HasMaxLength(100);
            this.Property(_ => _.SENHA).IsRequired().HasMaxLength(50);
            this.Property(_ => _.DT_CADASTRO).IsRequired();

            // Table & Column Mappings
            this.ToTable("ST_CLIENTE", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_CLIENTE");
            this.Property(_ => _.NOME).HasColumnName("NOME");
            this.Property(_ => _.EMAIL).HasColumnName("EMAIL");
            this.Property(_ => _.SENHA).HasColumnName("SENHA");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
        }
    }
}

