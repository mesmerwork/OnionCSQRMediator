using OnionTemplateEx.Application.Dtos;
using OnionTemplateEx.Application.Interfaces.Repositories.Country;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;

namespace OnionTemplateEx.Persistance.Repositories.Country
{
    public class WriteCountryRepository : WriteRepository<CountryEntity>, IWriteCountryRepository
    {
        public WriteCountryRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
