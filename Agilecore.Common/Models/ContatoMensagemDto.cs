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
    public class ContatoMensagemDto : Base
    {
        public System.Int32 ID_CONTATO { get; set; }
        public System.String EMAIL_FROM { get; set; }
        public System.String EMAIL_TO { get; set; }
        public System.String NOME { get; set; }
        public System.String TITULO { get; set; }
        public System.String DESCRICAO { get; set; }
        public System.DateTime DT_ENVIO { get; set; }
        public System.String STATUS { get; set; }
    }
}

