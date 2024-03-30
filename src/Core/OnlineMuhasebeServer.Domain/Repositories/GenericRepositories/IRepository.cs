using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstraction;
using OnlineMuhasebeServer.Domain.Entities;
using System.Linq.Expressions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories;
public interface IRepository<T>
    where T : class
{
    //DbSet<T> Entity { get; set; } //
    Task AddAsync(T entity, CancellationToken cancellationToken );

    void Add(T entity);

    Task AddRangeAsync(ICollection<T> entities, CancellationToken cancellationToken = default);

    void Update(T entity);

    void UpdateRange(ICollection<T> entities);

    Task DeleteByIdAsync(string id);

    Task DeleteByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

    void Delete(T entity);

    void DeleteRange(ICollection<T> entities);
    IQueryable<T> GetAll();

    IQueryable<T> GetAllWithTacking();

    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);

    IQueryable<T> GetWhereWithTracking(Expression<Func<T, bool>> expression);

    Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

    Task<T> GetByExpressionWithTrackingAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

    Task<T> GetFirstAsync(CancellationToken cancellationToken = default);

    Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

    bool Any(Expression<Func<T, bool>> expression);

    T GetByExpression(Expression<Func<T, bool>> expression);

    T GetByExpressionWithTracking(Expression<Func<T, bool>> expression);

    T GetFirst();
}
