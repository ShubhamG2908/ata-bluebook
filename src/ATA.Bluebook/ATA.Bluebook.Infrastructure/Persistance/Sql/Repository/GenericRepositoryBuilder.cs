using ATA.Application.Interface;
using ATA.Domain.Entity;
using ATA.Infrastructure.Persistance.Sql.DabaseContext;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using System.Linq.Expressions;
using System.Reflection;

namespace ATA.Infrastructure.Persistance.Sql.Repository
{
    public class GenericRepositoryBuilder<TEntity> : IGenericRepositoryBuilder<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _dbEntity;
        private Expression? _projection = null;
        private Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null;
        private Expression<Func<TEntity, object>>? _orderBy = null;
        private Expression<Func<TEntity, bool>>? where = null;
        private bool _orderByDescending = false;
        private string? _searchTerm = null;
        private string[]? _searchColumns = null;
        private bool _noTracking = false;

        public GenericRepositoryBuilder(ApplicationContext context)
        {
            _context = context;
            _dbEntity = context.Set<TEntity>();
        }

        public IGenericRepositoryBuilder<TEntity> WithNoTracking()
        {
            _noTracking = true;
            return this;
        }

        private IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> query)
        {
            // Apply Where
            if (where != null)
            {
                query = query.Where(where);
            }

            // Dynamic Search
            if (!string.IsNullOrEmpty(_searchTerm) && _searchColumns?.Any() == true)
            {
                Expression? combinedExpression = null;
                var parameter = Expression.Parameter(typeof(TEntity), "x");
                foreach (var propertyName in _searchColumns)
                {
                    var propertyExp = Expression.Property(parameter, propertyName);
                    MethodInfo? method = typeof(string).GetMethod("Contains", [typeof(string)]);

                    ArgumentNullException.ThrowIfNull(method);

                    var someValue = Expression.Constant(_searchTerm, typeof(string));
                    var containsMethodExp = Expression.Call(propertyExp, method, someValue);

                    combinedExpression = combinedExpression == null
                        ? containsMethodExp
                        : Expression.OrElse(combinedExpression, containsMethodExp);
                }

                if (combinedExpression != null)
                {
                    var lambda = Expression.Lambda<Func<TEntity, bool>>(combinedExpression, parameter);
                    query = query.Where(lambda);
                }
            }

            // Apply Include
            if (include != null)
            {
                query = include(query);
            }

            // Apply Order By
            if (_orderBy != null)
            {
                query = _orderByDescending
                    ? query.OrderByDescending(_orderBy)
                    : query.OrderBy(_orderBy);
            }

            if (_noTracking)
                query.AsNoTracking();

            return query;
        }

        public async Task<TResult?> ExecuteFirstAsync<TResult>()
        {
            var query = _context.Set<TEntity>().AsQueryable();
            query = ApplyFilter(query);

            if (_projection != null)
            {
                var projectionExpression = _projection as Expression<Func<TEntity, TResult>>;
                if (projectionExpression == null)
                {
                    throw new InvalidOperationException("Invalid projection expression.");
                }
                return await query.Select(projectionExpression).FirstOrDefaultAsync();
            }

            return await query.Cast<TResult?>().FirstOrDefaultAsync();
        }

        public async Task<List<TResult>> ExecuteListAsync<TResult>()
        {
            var query = _context.Set<TEntity>().AsQueryable();
            query = ApplyFilter(query);

            if (_projection != null)
            {
                var projectionExpression = _projection as Expression<Func<TEntity, TResult>>;
                if (projectionExpression == null)
                {
                    throw new InvalidOperationException("Invalid projection expression.");
                }
                return await query.Select(projectionExpression).ToListAsync();
            }

            return await query.Cast<TResult>().ToListAsync();
        }

        public async Task<(List<TResult> Items, int TotalCount)> ExecuteWithPaginationAsync<TResult>(int pageSize = 10, int pageNumber = 1)
        {
            var query = _dbEntity.AsQueryable();
            query = ApplyFilter(query);

            var totalCount = await query.CountAsync();

            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            List<TResult> items;
            var projectionExpression = _projection as Expression<Func<TEntity, TResult>>;

            if (projectionExpression != null)
                items = await query.Select(projectionExpression).ToListAsync();
            else
                items = await query.Cast<TResult>().ToListAsync();

            return (items, totalCount);
        }

        public IGenericRepositoryBuilder<TEntity> WithFilter(Expression<Func<TEntity, bool>> where)
        {
            this.where = where;
            return this;
        }

        public IGenericRepositoryBuilder<TEntity> WithInclude(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include)
        {
            this.include = include;
            return this;
        }

        public IGenericRepositoryBuilder<TEntity> WithOrderBy(Expression<Func<TEntity, object>> orderBy, bool isDescending = false)
        {
            _orderBy = Expression.Lambda<Func<TEntity, object>>(
               Expression.Convert(orderBy.Body, typeof(object)),
               orderBy.Parameters);

            _orderByDescending = isDescending;
            return this;
        }

        public IGenericRepositoryBuilder<TEntity> WithProjection<TResult>(Expression<Func<TEntity, TResult>> projection)
        {
            _projection = projection;
            return this;
        }

        public IGenericRepositoryBuilder<TEntity> WithSearch(string searchTerm, params string[] columns)
        {
            _searchTerm = searchTerm;
            _searchColumns = columns;
            return this;
        }

        public async Task<bool> UpSertAsync(TEntity entity)
        {
            var dbRecord = await _dbEntity.FindAsync(entity.Id);
            if (dbRecord == null)
            {
                entity.CreatedAt = DateTime.UtcNow;
                _dbEntity.Add(entity);
            }
            else
            {
                _context.Entry(dbRecord).CurrentValues.SetValues(entity);
                entity.UpdatedAt = DateTime.UtcNow;
                _context.Update(entity);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveAsync(Guid id, Guid userId)
        {
            var dbReocrd = await _dbEntity.FindAsync(id);
            if (dbReocrd != null)
            {
                dbReocrd.UpdatedAt = DateTime.UtcNow;
                dbReocrd.UpdatedBy = userId;
                dbReocrd.IsRemoved = true;
                _context.Update(dbReocrd);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
