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
    public class Contato
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Contato()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(ContatoDto model)
        {
            _unitOfWork.GetRepository<ContatoDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual ContatoDto SaveGetItem(ContatoDto model)
        {
           _unitOfWork.GetRepository<ContatoDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<ContatoDto> model)
        {
            _unitOfWork.GetRepository<ContatoDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(ContatoDto model)
        {
            _unitOfWork.GetRepository<ContatoDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual ContatoDto GetItem(Expression<Func<ContatoDto, bool>> filter)
        {
            ContatoDto model;
            model = _unitOfWork.GetRepository<ContatoDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<ContatoDto, bool>> filter)
        {
             _unitOfWork.GetRepository<ContatoDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<ContatoDto> GetByFilters(Expression<Func<ContatoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ContatoDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ContatoDto> GetByFilterAsQueryable(Expression<Func<ContatoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ContatoDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<ContatoDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ContatoDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<ContatoDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

