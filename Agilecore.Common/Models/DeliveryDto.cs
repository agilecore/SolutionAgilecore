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
    public class DeliveryDto : Base
    {
        public System.Int32 ID_PROJETO { get; set; }
        public System.Int32 ID_STEP { get; set; }
        public System.String NOME { get; set; }
        public System.String DESCRICAO { get; set; }
        public System.DateTime DT_CADASTRO { get; set; }
        public System.DateTime DT_ENTREGA { get; set; }
        public System.String STATUS { get; set; }
    }
}

