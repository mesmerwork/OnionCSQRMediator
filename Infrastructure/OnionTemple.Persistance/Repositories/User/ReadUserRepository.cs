using OnionTemplateEx.Application.Dtos;
using OnionTemplateEx.Application.Interfaces.Repositories.User;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories.User
{
    public class ReadUserRepository : ReadRepository<UserEntity>, IReadUserRepository
    {
        public ReadUserRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
