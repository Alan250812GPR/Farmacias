using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Farmacias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CuentasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[ServiceFilter(typeof(FiltersMid))]
        //[Authorize(Roles = "Super Admin")]
        [HttpGet]
        public string Get()
        {
            return "Running";
        }
    }
}
