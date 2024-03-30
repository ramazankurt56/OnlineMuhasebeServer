using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstraction;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using System.Linq.Expressions;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.GenericRepositories.CompanyDbContext;
public class CompanyDbRepository<T> : ICompanyDbRepository<T>
        where T : class
{
    private Context.CompanyDbContext _context;

    public void SetDbContextInstance(DbContext context)
    {
        _context = (Context.CompanyDbContext)context;
        Entity = _context.Set<T>();
    }
    public DbSet<T> Entity { get; set; }
    public void Delete(T entity)
    {
        Entity.Remove(entity);
    }
    public void Add(T entity)
    {
        Entity.Add(entity);
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        await Entity.AddAsync(entity, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
    }

    public async Task AddRangeAsync(ICollection<T> entities, CancellationToken cancellationToken = default)
    {
        await Entity.AddRangeAsync(entities, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
    }

    public async Task DeleteByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        T entity = await Entity.Where(expression).AsNoTracking().FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(continueOnCapturedContext: false);
        Entity.Remove(entity);
    }

    public async Task DeleteByIdAsync(string id)
    {
        T entity = await Entity.FindAsync(id).ConfigureAwait(continueOnCapturedContext: false);
        if (entity is not null)
        {
            Entity.Remove(entity);
        }

    }

    public void DeleteRange(ICollection<T> entities)
    {
        Entity.RemoveRange(entities);
    }
    public void Update(T entity)
    {
        Entity.Update(entity);
    }

    public void UpdateRange(ICollection<T> entities)
    {
        Entity.UpdateRange(entities);
    }
    public bool Any(Expression<Func<T, bool>> expression)
    {
        return Entity.Any(expression);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await Entity.AnyAsync(expression, cancellationToken);
    }
    public IQueryable<T> GetAll()
    {
        return Entity.AsNoTracking().AsQueryable();
    }

    public IQueryable<T> GetAllWithTacking()
    {
        return Entity.AsQueryable();
    }

    public T GetByExpression(Expression<Func<T, bool>> expression)
    {
        return Entity.Where(expression).AsNoTracking().FirstOrDefault();
    }

    public async Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await Entity.Where(expression).AsNoTracking().FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(continueOnCapturedContext: false);
    }

    public T GetByExpressionWithTracking(Expression<Func<T, bool>> expression)
    {
        return Entity.Where(expression).FirstOrDefault();
    }

    public async Task<T> GetByExpressionWithTrackingAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await Entity.Where(expression).FirstOrDefaultAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
    }

    public T GetFirst()
    {
        return Entity.AsNoTracking().FirstOrDefault();
    }

    public async Task<T> GetFirstAsync(CancellationToken cancellationToken = default)
    {
        return await Entity.AsNoTracking().FirstOrDefaultAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return Entity.AsNoTracking().Where(expression).AsQueryable();
    }

    public IQueryable<T> GetWhereWithTracking(Expression<Func<T, bool>> expression)
    {
        return Entity.Where(expression).AsQueryable();
    }

 
}
