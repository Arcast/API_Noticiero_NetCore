using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Noticiero_NetCore.Models;
using API_Noticiero_NetCore.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Noticiero_NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        public readonly AutorService _autorservice;
        public AutorController(AutorService autorService)
        {
            _autorservice = autorService;
        }

        [HttpGet]
        [Route("Mostrar")]
        public IActionResult MostrarListado()
        {
            var resultado = _autorservice.ListarAutores();
            return Ok(resultado);           
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult GuardarAutor([FromBody] Autor _autor)
        {
            var resultado = _autorservice.AgregarAutor(_autor);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPut]
        [Route("Modificar")]
        public IActionResult ModificarAutor([FromBody] Autor _autor)
        {
            var resultado = _autorservice.EditarAutor(_autor);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarAutor(Autor _autor)
        {
            var resultado = _autorservice.EliminarAutor(_autor);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}