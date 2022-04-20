using OnionTemplateEx.Application.Interfaces.Repositories.Employee;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories.Employee
{
    public class ReadEmployeeRepository : ReadRepository<EmployeeEntity>, IReadEmployeeRepository
    {
        public ReadEmployeeRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
