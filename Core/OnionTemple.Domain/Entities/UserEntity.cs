using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class UserEntity :BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
