using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Dtos
{
    public class CountryDto :BaseDto
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Capital { get; set; }
        public ICollection<OfficeDto> Offices { get; set; }
    }
}
