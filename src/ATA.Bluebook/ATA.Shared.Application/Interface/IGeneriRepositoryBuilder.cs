using ATA.Shared.Domain.Entity;

using System.Linq.Expressions;

namespace ATA.Shared.Application.Interface
{
    public interface IGenericRepositoryBuilder<TEntity> where TEntity : BaseEntity
    {
        IGenericRepositoryBuilder<TEntity> WithFilter(Expression<Func<TEntity, bool>> filter);
        IGenericRepositoryBuilder<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool isDescending = false);
        IGenericRepositoryBuilder<TEntity> WithPagination(int pageNumber, int pageSize);
        IGenericRepositoryBuilder<TEntity> Project<TResult>(Expression<Func<TEntity, TResult>> projection);
        IGenericRepositoryBuilder<TEntity> SearchColumns(string searchTerm, params string[] propertyNames);
        IGenericRepositoryBuilder<TEntity> IgnoreTenantFilter();
        Task<List<TResult>> ExecuteAsync<TResult>();
        Task<TResult> ExecuteSingleAsync<TResult>();
        Task<(List<TResult> Items, int TotalCount)> ExecuteWithPaginationAsync<TResult>();
        Task<TEntity> UpsertAsync(TEntity entity);
    }
}
