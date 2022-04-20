using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class OfficeEntity : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int? CountryId { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
        public CountryEntity Country{ get; set; }
    }
}
