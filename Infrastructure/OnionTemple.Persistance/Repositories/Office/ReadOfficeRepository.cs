using OnionTemplateEx.Application.Interfaces.Repositories.Office;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories.Office
{
    public class ReadOfficeRepository : ReadRepository<OfficeEntity>, IReadOfficeRepository
    {
        public ReadOfficeRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
