using OnionTemplateEx.Application.Dtos;
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
    public class WriteOfficeRepository : WriteRepository<OfficeEntity>, IWriteOfficeRepository
    {
        public WriteOfficeRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
