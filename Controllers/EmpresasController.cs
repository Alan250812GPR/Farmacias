﻿using Farmacias_Aplication.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetEmpresas")]
        public string GetEmpresas()
        {
            return "Running";
        }

        [Authorize(Roles = "Root, Administrador")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpGet("GetEmpresa")]
        public string GetEmpresa()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPost("PostAgregarEmpresa")]
        public string PostAgregarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpPut("PutActualizarEmpresa")]
        public string PutActualizarUsuarios()
        {
            return "Running";
        }

        [Authorize(Roles = "Root")]
        [ServiceFilter(typeof(FiltersMid))]
        [HttpDelete("DeleteEmpresa")]
        public string DeleteUsuarios()
        {
            return "Running";
        }
    }
}
