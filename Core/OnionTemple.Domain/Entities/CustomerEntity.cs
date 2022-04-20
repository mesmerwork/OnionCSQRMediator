using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class CustomerEntity : BaseEntity
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }
        public string  City { get; set; }
        public int ? EmployeeId { get; set; }
        public ICollection<PaymentEntity> Payments { get; set; }
        public EmployeeEntity Employee { get; set; }

    }
}
