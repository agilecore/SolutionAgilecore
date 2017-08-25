using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class ContatoMensagemMapper : EntityTypeConfiguration<ContatoMensagemDto>
    {
        public ContatoMensagemMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.ID_CONTATO).IsRequired();
            this.Property(_ => _.EMAIL_FROM).IsRequired().HasMaxLength(100);
            this.Property(_ => _.EMAIL_TO).IsRequired().HasMaxLength(100);
            this.Property(_ => _.NOME).IsRequired().HasMaxLength(100);
            this.Property(_ => _.TITULO).IsRequired().HasMaxLength(255);
            this.Property(_ => _.DESCRICAO).IsRequired().HasMaxLength(2147483647);
            this.Property(_ => _.DT_ENVIO).IsRequired();
            this.Property(_ => _.STATUS).IsRequired().HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ST_CONTATO_MENSAGEM", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_CONTATO_MENSAGEM");
            this.Property(_ => _.ID_CONTATO).HasColumnName("ID_CONTATO");
            this.Property(_ => _.EMAIL_FROM).HasColumnName("EMAIL_FROM");
            this.Property(_ => _.EMAIL_TO).HasColumnName("EMAIL_TO");
            this.Property(_ => _.NOME).HasColumnName("NOME");
            this.Property(_ => _.TITULO).HasColumnName("TITULO");
            this.Property(_ => _.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(_ => _.DT_ENVIO).HasColumnName("DT_ENVIO");
            this.Property(_ => _.STATUS).HasColumnName("STATUS");
        }
    }
}

