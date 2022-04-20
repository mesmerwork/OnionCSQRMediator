using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OnionTemplateEx.Application.Interfaces.Repositories;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {

        private readonly OnionTemplateExDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public WriteRepository(OnionTemplateExDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await _dbSet.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> models)
        {
            await _dbSet.AddRangeAsync(models);
            return true;
        }

        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = _dbSet.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = _dbSet.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
