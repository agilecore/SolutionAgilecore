using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agilecore.Common
{
    /// <summary>
    /// Nao alterar essa classe pois ela é o objeto identico a tabela do banco de dados.
    /// </summary>
    public class PerfilUsuarioDto : Base
    {
        public System.Int32 ID_USUARIO { get; set; }
        public System.Int32 ID_PERFIL { get; set; }
        public System.Int32 ID_USUARIO_CONCEDEU { get; set; }
        public System.DateTime DT_CADASTRO { get; set; }
    }
}

