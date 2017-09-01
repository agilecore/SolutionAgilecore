using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class DeliveryMapper : EntityTypeConfiguration<DeliveryDto>
    {
        public DeliveryMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.ID_PROJETO).IsRequired();
            this.Property(_ => _.ID_STEP).IsRequired();
            this.Property(_ => _.NOME).IsRequired().HasMaxLength(100);
            this.Property(_ => _.DESCRICAO).IsRequired().HasMaxLength(2147483647);
            this.Property(_ => _.DT_CADASTRO).IsRequired();
            this.Property(_ => _.DT_ENTREGA).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ST_DELIVERY", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_DELIVERY");
            this.Property(_ => _.ID_PROJETO).HasColumnName("ID_PROJETO");
            this.Property(_ => _.ID_STEP).HasColumnName("ID_STEP");
            this.Property(_ => _.NOME).HasColumnName("NOME");
            this.Property(_ => _.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
            this.Property(_ => _.DT_ENTREGA).HasColumnName("DT_ENTREGA");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

