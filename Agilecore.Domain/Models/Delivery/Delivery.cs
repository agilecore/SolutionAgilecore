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
    public class Delivery
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Delivery()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(DeliveryDto model)
        {
            _unitOfWork.GetRepository<DeliveryDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual DeliveryDto SaveGetItem(DeliveryDto model)
        {
           _unitOfWork.GetRepository<DeliveryDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<DeliveryDto> model)
        {
            _unitOfWork.GetRepository<DeliveryDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(DeliveryDto model)
        {
            _unitOfWork.GetRepository<DeliveryDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual DeliveryDto GetItem(Expression<Func<DeliveryDto, bool>> filter)
        {
            DeliveryDto model;
            model = _unitOfWork.GetRepository<DeliveryDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<DeliveryDto, bool>> filter)
        {
             _unitOfWork.GetRepository<DeliveryDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<DeliveryDto> GetByFilters(Expression<Func<DeliveryDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<DeliveryDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<DeliveryDto> GetByFilterAsQueryable(Expression<Func<DeliveryDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<DeliveryDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<DeliveryDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<DeliveryDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<DeliveryDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

