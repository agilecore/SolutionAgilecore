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
    public class LogAcessoDto : Base
    {
        public System.String IPV6 { get; set; }
        public System.String DOMAIN { get; set; }
        public System.String BROWSER { get; set; }
        public System.String BROWSER_VERSION { get; set; }
        public System.String SO { get; set; }
        public System.String DEVICE { get; set; }
        public System.DateTime DT_ACESSO { get; set; }
        public System.String STATUS { get; set; }
    }
}

