using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class ProjetoMapper : EntityTypeConfiguration<ProjetoDto>
    {
        public ProjetoMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.ID_CLIENTE).IsRequired();
            this.Property(_ => _.NOME).IsRequired().HasMaxLength(100);
            this.Property(_ => _.DESCRICAO).IsRequired().HasMaxLength(2147483647);
            this.Property(_ => _.DT_CADASTRO).IsRequired();

            // Table & Column Mappings
            this.ToTable("ST_PROJETO", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_PROJETO");
            this.Property(_ => _.ID_CLIENTE).HasColumnName("ID_CLIENTE");
            this.Property(_ => _.NOME).HasColumnName("NOME");
            this.Property(_ => _.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
        }
    }
}

