using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador.Models;

namespace Gerador.Models
{
    public sealed class TableToClass
    {
        public Dictionary<String, ModelConfig> GetTableMapper()
        {
            var Storage = new Dictionary<String, ModelConfig>();

            Storage.Add("USUARIO", new ModelConfig() { ClassName = "Usuario", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = false });
            Storage.Add("PERFIL", new ModelConfig() { ClassName = "Perfil", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = false });
            Storage.Add("PERFIL_USUARIO", new ModelConfig() { ClassName = "PerfilUsuario", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = false });
            Storage.Add("LOG_ACESSO", new ModelConfig() { ClassName = "LogAcesso", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = false });
            Storage.Add("ST_ATUACAO", new ModelConfig() { ClassName = "Atuacao", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = true });
            Storage.Add("ST_CONTATO", new ModelConfig() { ClassName = "Contato", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = true });
            Storage.Add("ST_CONTATO_MENSAGEM", new ModelConfig() { ClassName = "ContatoMensagem", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = false });
            Storage.Add("ST_INSTITUCIONAL", new ModelConfig() { ClassName = "Institucional", NameSpaceDto = "Agilecore.Data", NameSpaceMapper = "Agilecore.Data", NameSpaceDomain = "Agilecore.Domain", NameSpaceService = "Agilecore.Service", CreateController = true });


            return (Storage);
        }
    }
}
