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
    public class Step
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Step()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(StepDto model)
        {
            _unitOfWork.GetRepository<StepDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual StepDto SaveGetItem(StepDto model)
        {
           _unitOfWork.GetRepository<StepDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<StepDto> model)
        {
            _unitOfWork.GetRepository<StepDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(StepDto model)
        {
            _unitOfWork.GetRepository<StepDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual StepDto GetItem(Expression<Func<StepDto, bool>> filter)
        {
            StepDto model;
            model = _unitOfWork.GetRepository<StepDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<StepDto, bool>> filter)
        {
             _unitOfWork.GetRepository<StepDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<StepDto> GetByFilters(Expression<Func<StepDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<StepDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<StepDto> GetByFilterAsQueryable(Expression<Func<StepDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<StepDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<StepDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<StepDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<StepDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

