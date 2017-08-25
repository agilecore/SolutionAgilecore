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
    public class Atuacao
    {
        public UnitOfWork _unitOfWork {get; set;}

        /// <summary>
        /// Construtor
        /// </summary>
        public Atuacao()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Salva um objeto<T>
        /// </summary>
        public virtual void Save(AtuacaoDto model)
        {
            _unitOfWork.GetRepository<AtuacaoDto>().Add(model);
        }

        /// <summary>
        /// Salva e retorna o objeto<T> salvo
        /// </summary>
        public virtual AtuacaoDto SaveGetItem(AtuacaoDto model)
        {
           _unitOfWork.GetRepository<AtuacaoDto>().Add(model);
           return (model);
        }

        /// <summary>
        /// Salva uma lista de objetos List<T>
        /// </summary>
        public virtual void SaveAll(List<AtuacaoDto> model)
        {
            _unitOfWork.GetRepository<AtuacaoDto>().AddAll(model);
        }

        /// <summary>
        /// Salva a edição de um objeto<T>
        /// </summary>
        public virtual void Update(AtuacaoDto model)
        {
            _unitOfWork.GetRepository<AtuacaoDto>().Update(model);
        }

        /// <summary>
        /// Retorna um único objeto<T> buscado por expressão Lambda
        /// </summary>
        public virtual AtuacaoDto GetItem(Expression<Func<AtuacaoDto, bool>> filter)
        {
            AtuacaoDto model;
            model = _unitOfWork.GetRepository<AtuacaoDto>().GetByFilters(filter).FirstOrDefault();
            return (model);
        }

        /// <summary>
        /// Deleta um ou uma lista de objetos
        /// </summary>
        public virtual void Delete(Expression<Func<AtuacaoDto, bool>> filter)
        {
             _unitOfWork.GetRepository<AtuacaoDto>().Delete(filter);
        }

        /// <summary>
        /// Retorna uma lista List(T) de objetos buscados pela expressão Lambda
        /// </summary>
        public List<AtuacaoDto> GetByFilters(Expression<Func<AtuacaoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<AtuacaoDto>().GetByFilters(Filter);
            return (Collection.ToList());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <param name="Filter">Filtro exemplo: GetByFilter(obj => obj.ID, null).</param>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<AtuacaoDto> GetByFilterAsQueryable(Expression<Func<AtuacaoDto, bool>> Filter = null)
        {
            var Collection = _unitOfWork.GetRepository<AtuacaoDto>().GetByFilters(Filter);
            return (Collection.AsQueryable<AtuacaoDto>());
        }

        /// <summary>
        /// Retorna um objeto IQueryable manipulavel em tempo de execução.
        /// </summary>
        /// <returns>Retorna um objeto IQueryable</returns>
        public IQueryable<AtuacaoDto> GetAll()
        {
            var model = _unitOfWork.GetRepository<AtuacaoDto>().GetAll().AsQueryable();
            return (model);
        }

    }
}

