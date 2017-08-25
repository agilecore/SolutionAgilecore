using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Agilecore.Data;
using Agilecore.Common;

/// <summary>
/// Esta classe contem metodos de negocios (domain) principais, prontos para uso em controllers, porem se esse objeto
/// necessita de um metodo customizado (particular), fazer a implementacao na classe Specialized, e nao aqui.
/// </summary>
namespace Agilecore.Domain
{
    public class ContatoMensagem
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public ContatoMensagem()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(ContatoMensagemDto model)
        {
            _unitOfWork.GetRepository<ContatoMensagemDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual ContatoMensagemDto SaveGetItem(ContatoMensagemDto model)
        {
           _unitOfWork.GetRepository<ContatoMensagemDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<ContatoMensagemDto> model)
        {
            _unitOfWork.GetRepository<ContatoMensagemDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(ContatoMensagemDto model)
        {
            _unitOfWork.GetRepository<ContatoMensagemDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual ContatoMensagemDto GetItem(Expression<Func<ContatoMensagemDto, bool>> filter)
        {
            ContatoMensagemDto model;
            model = _unitOfWork.GetRepository<ContatoMensagemDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<ContatoMensagemDto, bool>> filter)
        {
             _unitOfWork.GetRepository<ContatoMensagemDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<ContatoMensagemDto> GetByFilters(Expression<Func<ContatoMensagemDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ContatoMensagemDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ContatoMensagemDto> GetByFilterAsQueryable(Expression<Func<ContatoMensagemDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ContatoMensagemDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<ContatoMensagemDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ContatoMensagemDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<ContatoMensagemDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

