using ATA.Application.Models;
using ATA.Domain.Entity;
using Microsoft.EntityFrameworkCore.Query;

using System.Linq.Expressions;

namespace ATA.Application.Interface
{
    public interface IGenericRepositoryBuilder<TEntity> where TEntity : BaseEntity
    {
        IGenericRepositoryBuilder<TEntity> WithSearch(string searchTerm, params string[] columns);
        Task<bool> RemoveAsync(Guid id, Guid userId);
        Task<(List<TResult> Items, int TotalCount)> ExecuteWithPaginationAsync<TResult>(int pageSize = 10, int pageNumber = 1);
        IGenericRepositoryBuilder<TEntity> WithFilter(Expression<Func<TEntity, bool>> where);
        IGenericRepositoryBuilder<TEntity> WithOrderBy(Expression<Func<TEntity, object>> orderBy, bool isDescending = false);
        IGenericRepositoryBuilder<TEntity> WithInclude(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include);
        IGenericRepositoryBuilder<TEntity> WithProjection<TResult>(Expression<Func<TEntity, TResult>> projection);
        Task<List<TResult>> ExecuteListAsync<TResult>();
        Task<TResult?> ExecuteFirstAsync<TResult>();
        Task<bool> UpSertAsync(TEntity entity);
    }
}
