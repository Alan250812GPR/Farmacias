using Farmacias_Domain.Interfaces;
using Farmacias_Infrastructure.Queries;
using Farmacias_Models.Models;
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
        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        [HttpPost("login")]
        public async Task<ActionResult<jwtModel>> GetByUser([FromBody] GetUserByUserNameInterface userNameInterface)
        {
            var query = new GetByUserQuery(userNameInterface);
            var userItem = await _mediator.Send(query);

            if (userItem == null)
            {
                return NotFound();
            }

            return Ok(userItem);
        }
    }
}
