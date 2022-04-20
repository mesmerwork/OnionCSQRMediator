using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Dtos
{
    public class CustomerDto : BaseDto
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? EmployeeId { get; set; }
        public ICollection<PaymentDto> Payments { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
