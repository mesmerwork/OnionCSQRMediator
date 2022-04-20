using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Dtos
{
    public class EmployeeDto : BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? OfficeId { get; set; }
        public string JobTitle { get; set; }
        public OfficeDto Office { get; set; }
        public ICollection<CustomerDto> Customers { get; set; }
    }
}
