using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class ContatoMapper : EntityTypeConfiguration<ContatoDto>
    {
        public ContatoMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.TITULO).IsRequired().HasMaxLength(255);
            this.Property(_ => _.DT_CADASTRO).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ST_CONTATO", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_CONTATO");
            this.Property(_ => _.TITULO).HasColumnName("TITULO");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

