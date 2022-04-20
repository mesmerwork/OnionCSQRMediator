using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string Id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method);        
        Task<List<T>> GetAll();
       
    }
}
