using AutoMapper;
using MediatR;
using OnionTemplateEx.Application.Dtos;
using OnionTemplateEx.Application.Interfaces.Repositories.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Features.Queries.Country
{
    public class GetAllCountryQuery : IRequest<List<CountryDto>>
    {

        public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, List<CountryDto>>
        {

            private readonly IReadCountryRepository _readCountryRepository;
            private readonly IMapper _mapper;


            public GetAllCountryQueryHandler(IReadCountryRepository readCountryRepository, IMapper mapper)
            {
                _readCountryRepository = readCountryRepository;
                _mapper = mapper;
            }

            
            public async Task<List<CountryDto>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
            {
                var countries = await _readCountryRepository.GetAll();
                var data = _mapper.Map<List<CountryDto>>(countries);

                return new List<CountryDto>(data);
            }
        }
    }
}
