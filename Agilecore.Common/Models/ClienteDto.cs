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
    public class ClienteDto : Base
    {
        public System.String NOME { get; set; }
        public System.String EMAIL { get; set; }
        public System.String SENHA { get; set; }
        public System.DateTime DT_CADASTRO { get; set; }
    }
}
