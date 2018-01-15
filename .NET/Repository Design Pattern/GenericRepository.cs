public class GenericRepository<TEntity> where TEntity : class
{
    // use DbContext, do not abstract the dbContext.
    internal DbContext _context;
    internal DbSet<TEntity> _dbSet;

    public GenericRepository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public IQueryable<TEntity> All()
    {
      IQueryable<TEntity> query = _dbSet;
      return = _dbSet;
    }

    public T Find(int id)
    {
      return _dbSet.Find(id);
    }

    public void Insert(TEntity entity)
    {
      _dbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
      _dbSet.Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
      var entity = Find(id);
      _dbSet.Remove(entity);
    }
}