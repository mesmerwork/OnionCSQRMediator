using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Dtos
{
    public class OfficeDto : BaseDto
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int? CountryId { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
        public CountryDto Country { get; set; }
    }
}
