using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionTemplateEx.Application.Features.Queries.Country;

namespace OnionTemplateEx.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllCountryQuery();
            return Ok(await _mediator.Send(query));
        }
    }
}
