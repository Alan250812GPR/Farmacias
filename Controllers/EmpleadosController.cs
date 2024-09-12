using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace bsrr_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmpleadosController(IMediator mediator)
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
