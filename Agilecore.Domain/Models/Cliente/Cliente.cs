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
    public class Cliente
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Cliente()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(ClienteDto model)
        {
            _unitOfWork.GetRepository<ClienteDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual ClienteDto SaveGetItem(ClienteDto model)
        {
           _unitOfWork.GetRepository<ClienteDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<ClienteDto> model)
        {
            _unitOfWork.GetRepository<ClienteDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(ClienteDto model)
        {
            _unitOfWork.GetRepository<ClienteDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual ClienteDto GetItem(Expression<Func<ClienteDto, bool>> filter)
        {
            ClienteDto model;
            model = _unitOfWork.GetRepository<ClienteDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<ClienteDto, bool>> filter)
        {
             _unitOfWork.GetRepository<ClienteDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<ClienteDto> GetByFilters(Expression<Func<ClienteDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ClienteDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ClienteDto> GetByFilterAsQueryable(Expression<Func<ClienteDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ClienteDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<ClienteDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ClienteDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<ClienteDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

