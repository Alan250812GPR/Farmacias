using Farmacias_Aplication.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        [Authorize(Roles = "Root,Administrador,Usuario")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetSaldocuenta")]
        public string GetSaldocuenta()
        {
            return "Running";
        }
        
        [Authorize(Roles = "Root,Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostCrearCuenta")]
        public string PostCrearCuenta()
        {
            return "Running";
        }
        
        [Authorize(Roles = "Root,Usuario")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostTransferencia")]
        public string PostTransferencia()
        {
            return "Running";
        }
        
        [Authorize(Roles = "Root,Usuario")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostDeposito")]
        public string PostDeposito()
        {
            return "Running";
        }
        
        [Authorize(Roles = "Root,Usuario")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostRetiro")]
        public string PostRetiro()
        {
            return "Running";
        }
    }
}
