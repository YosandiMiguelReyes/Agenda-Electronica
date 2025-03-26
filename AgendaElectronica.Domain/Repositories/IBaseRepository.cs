

using AgendaElectronica.Domain.Result;
using System.Linq.Expressions;

namespace AgendaElectronica.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<OperationResult> Add(TEntity entity);
        Task<OperationResult> Update(TEntity entity);
        Task<OperationResult> Delete(TEntity entity);
        Task<OperationResult> GetAll();
        Task<OperationResult> GetById(int id);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
