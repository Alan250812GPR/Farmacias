using Farmacias_Aplication.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Farmacias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetUsuarios")]
        public string GetUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador,Usuario")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetUsuario")]
        public string GetUsuario()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostAgregarUsuarios")]
        public string PostAgregarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPut("PutActualizarUsuarios")]
        public string PutActualizarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpDelete("DeleteActualizarUsuarios")]
        public string DeleteUsuarios()
        {
            return "Running";
        }
    }
}
