using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Dtos
{
    public class PaymentDto : BaseDto
    {
        public double Amount { get; set; }
        public int? CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
