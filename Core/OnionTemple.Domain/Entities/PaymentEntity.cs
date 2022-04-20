using OnionTemplateEx.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Domain.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public double Amount { get; set; }
        public int? CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
