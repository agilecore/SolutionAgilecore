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
    public class InstitucionalDto : Base
    {
        public System.String TITULO { get; set; }
        public System.String DESCRICAO { get; set; }
        public System.DateTime DT_CADASTRO { get; set; }
        public System.Int32 ORDEM { get; set; }
        public System.String STATUS { get; set; }
    }
}

