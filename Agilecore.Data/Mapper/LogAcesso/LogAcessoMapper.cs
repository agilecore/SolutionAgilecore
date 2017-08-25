using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class LogAcessoMapper : EntityTypeConfiguration<LogAcessoDto>
    {
        public LogAcessoMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.IPV6).IsRequired().HasMaxLength(100);
            this.Property(_ => _.DOMAIN).IsRequired().HasMaxLength(100);
            this.Property(_ => _.BROWSER).IsRequired().HasMaxLength(100);
            this.Property(_ => _.BROWSER_VERSION).IsRequired().HasMaxLength(100);
            this.Property(_ => _.SO).IsRequired().HasMaxLength(100);
            this.Property(_ => _.DEVICE).IsRequired().HasMaxLength(100);
            this.Property(_ => _.DT_ACESSO).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LOG_ACESSO", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_LOG_ACESSO");
            this.Property(_ => _.IPV6).HasColumnName("IPV6");
            this.Property(_ => _.DOMAIN).HasColumnName("DOMAIN");
            this.Property(_ => _.BROWSER).HasColumnName("BROWSER");
            this.Property(_ => _.BROWSER_VERSION).HasColumnName("BROWSER_VERSION");
            this.Property(_ => _.SO).HasColumnName("SO");
            this.Property(_ => _.DEVICE).HasColumnName("DEVICE");
            this.Property(_ => _.DT_ACESSO).HasColumnName("DT_ACESSO");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

