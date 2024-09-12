using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Farmacias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
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
