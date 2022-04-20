using OnionTemplateEx.Application.Dtos;
using OnionTemplateEx.Application.Interfaces.Repositories.Country;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;

namespace OnionTemplateEx.Persistance.Repositories.Country
{
    public class ReadCountryRepository : ReadRepository<CountryEntity>, IReadCountryRepository
    {
        public ReadCountryRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
