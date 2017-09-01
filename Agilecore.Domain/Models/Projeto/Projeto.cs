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
    public class Projeto
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Projeto()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(ProjetoDto model)
        {
            _unitOfWork.GetRepository<ProjetoDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual ProjetoDto SaveGetItem(ProjetoDto model)
        {
           _unitOfWork.GetRepository<ProjetoDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<ProjetoDto> model)
        {
            _unitOfWork.GetRepository<ProjetoDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(ProjetoDto model)
        {
            _unitOfWork.GetRepository<ProjetoDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual ProjetoDto GetItem(Expression<Func<ProjetoDto, bool>> filter)
        {
            ProjetoDto model;
            model = _unitOfWork.GetRepository<ProjetoDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<ProjetoDto, bool>> filter)
        {
             _unitOfWork.GetRepository<ProjetoDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<ProjetoDto> GetByFilters(Expression<Func<ProjetoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ProjetoDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ProjetoDto> GetByFilterAsQueryable(Expression<Func<ProjetoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<ProjetoDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<ProjetoDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<ProjetoDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<ProjetoDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

