using Farmacias_Aplication.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetEmpleados")]
        public string GetEmpleados()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetEmpleado")]
        public string GetEmpleado()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostAgregarEmpleado")]
        public string PostAgregarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPut("PutActualizarEmpleado")]
        public string PutActualizarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpDelete("DeleteEmpleado")]
        public string DeleteEmpleado()
        {
            return "Running";
        }
    }
}
