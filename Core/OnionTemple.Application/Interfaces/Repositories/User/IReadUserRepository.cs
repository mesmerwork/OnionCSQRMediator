using OnionTemplateEx.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Interfaces.Repositories.User
{
    public interface IReadUserRepository : IReadRepository<UserEntity>
    {
    }
}
