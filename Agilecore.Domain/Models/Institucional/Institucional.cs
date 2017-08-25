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
    public class Institucional
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Institucional()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(InstitucionalDto model)
        {
            _unitOfWork.GetRepository<InstitucionalDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual InstitucionalDto SaveGetItem(InstitucionalDto model)
        {
           _unitOfWork.GetRepository<InstitucionalDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<InstitucionalDto> model)
        {
            _unitOfWork.GetRepository<InstitucionalDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(InstitucionalDto model)
        {
            _unitOfWork.GetRepository<InstitucionalDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual InstitucionalDto GetItem(Expression<Func<InstitucionalDto, bool>> filter)
        {
            InstitucionalDto model;
            model = _unitOfWork.GetRepository<InstitucionalDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<InstitucionalDto, bool>> filter)
        {
             _unitOfWork.GetRepository<InstitucionalDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<InstitucionalDto> GetByFilters(Expression<Func<InstitucionalDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<InstitucionalDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<InstitucionalDto> GetByFilterAsQueryable(Expression<Func<InstitucionalDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<InstitucionalDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<InstitucionalDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<InstitucionalDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<InstitucionalDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

