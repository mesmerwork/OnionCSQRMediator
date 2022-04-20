using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? OfficeId { get; set; }
        public string JobTitle { get; set; }
        public OfficeEntity Office { get; set; }
        public ICollection<CustomerEntity> Customers { get; set; }
    }
}
