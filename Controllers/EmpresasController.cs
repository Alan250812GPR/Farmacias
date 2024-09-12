using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Farmacias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmpresasController(IMediator mediator)
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
