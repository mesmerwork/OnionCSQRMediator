using OnionTemplateEx.Application.Interfaces.Repositories.Customer;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories.Customer
{
    public class WriteCustomerRepository : WriteRepository<CustomerEntity>, IWriteCustomerRepository
    {
        public WriteCustomerRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
