using System.Data.Entity.ModelConfiguration;
using Agilecore.Common;

namespace Agilecore.Data
{
    public class PerfilUsuarioMapper : EntityTypeConfiguration<PerfilUsuarioDto>
    {
        public PerfilUsuarioMapper()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Propertys Required
            this.Property(_ => _.ID_USUARIO).IsRequired();
            this.Property(_ => _.ID_PERFIL).IsRequired();
            this.Property(_ => _.ID_USUARIO_CONCEDEU).IsRequired();
            this.Property(_ => _.DT_CADASTRO).IsRequired();

            // Table & Column Mappings
            this.ToTable("PERFIL_USUARIO", "dbo");

            // Propertys Relationship Database Table Columns
            this.Property(_ => _.ID).HasColumnName("ID_PERFIL_USUARIO");
            this.Property(_ => _.ID_USUARIO).HasColumnName("ID_USUARIO");
            this.Property(_ => _.ID_PERFIL).HasColumnName("ID_PERFIL");
            this.Property(_ => _.ID_USUARIO_CONCEDEU).HasColumnName("ID_USUARIO_CONCEDEU");
            this.Property(_ => _.DT_CADASTRO).HasColumnName("DT_CADASTRO");
        }
    }
}

