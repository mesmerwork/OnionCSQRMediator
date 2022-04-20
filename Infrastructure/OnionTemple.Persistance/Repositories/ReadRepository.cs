using Microsoft.EntityFrameworkCore;
using OnionTemplateEx.Application.Interfaces.Repositories;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly OnionTemplateExDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public ReadRepository(OnionTemplateExDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(string Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            return await _dbSet.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return _dbSet.Where(method);
        }
    }
}
