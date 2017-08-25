using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class InstitucionalMapper : EntityTypeConfiguration<InstitucionalDto>
    {
        public InstitucionalMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.TITULO).IsRequired().HasMaxLength(255);
            this.Property(_ => _.DESCRICAO).IsRequired().HasMaxLength(2147483647);
            this.Property(_ => _.DT_CADASTRO).IsRequired();
            this.Property(_ => _.ORDEM).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ST_INSTITUCIONAL", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_INSTITUCIONAL");
            this.Property(_ => _.TITULO).HasColumnName("TITULO");
            this.Property(_ => _.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
            this.Property(_ => _.ORDEM).HasColumnName("ORDEM");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

