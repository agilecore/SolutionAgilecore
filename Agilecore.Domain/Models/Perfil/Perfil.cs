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
    public class Perfil
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Perfil()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(PerfilDto model)
        {
            _unitOfWork.GetRepository<PerfilDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual PerfilDto SaveGetItem(PerfilDto model)
        {
           _unitOfWork.GetRepository<PerfilDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<PerfilDto> model)
        {
            _unitOfWork.GetRepository<PerfilDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(PerfilDto model)
        {
            _unitOfWork.GetRepository<PerfilDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual PerfilDto GetItem(Expression<Func<PerfilDto, bool>> filter)
        {
            PerfilDto model;
            model = _unitOfWork.GetRepository<PerfilDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<PerfilDto, bool>> filter)
        {
             _unitOfWork.GetRepository<PerfilDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<PerfilDto> GetByFilters(Expression<Func<PerfilDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<PerfilDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<PerfilDto> GetByFilterAsQueryable(Expression<Func<PerfilDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<PerfilDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<PerfilDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<PerfilDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<PerfilDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

