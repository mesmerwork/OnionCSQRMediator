using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class CountryEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Capital { get; set; }
        public ICollection<OfficeEntity> Offices { get; set; }
    }
}
