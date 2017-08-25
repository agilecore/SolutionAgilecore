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
    public class PerfilUsuario
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public PerfilUsuario()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(PerfilUsuarioDto model)
        {
            _unitOfWork.GetRepository<PerfilUsuarioDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual PerfilUsuarioDto SaveGetItem(PerfilUsuarioDto model)
        {
           _unitOfWork.GetRepository<PerfilUsuarioDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<PerfilUsuarioDto> model)
        {
            _unitOfWork.GetRepository<PerfilUsuarioDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(PerfilUsuarioDto model)
        {
            _unitOfWork.GetRepository<PerfilUsuarioDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual PerfilUsuarioDto GetItem(Expression<Func<PerfilUsuarioDto, bool>> filter)
        {
            PerfilUsuarioDto model;
            model = _unitOfWork.GetRepository<PerfilUsuarioDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<PerfilUsuarioDto, bool>> filter)
        {
             _unitOfWork.GetRepository<PerfilUsuarioDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<PerfilUsuarioDto> GetByFilters(Expression<Func<PerfilUsuarioDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<PerfilUsuarioDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<PerfilUsuarioDto> GetByFilterAsQueryable(Expression<Func<PerfilUsuarioDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<PerfilUsuarioDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<PerfilUsuarioDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<PerfilUsuarioDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<PerfilUsuarioDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

