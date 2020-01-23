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
    public class NoticiaController : ControllerBase
    {
        public readonly NoticiaService _noticiaService;
        public NoticiaController(NoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        [HttpGet]
        [Route("Mostrar")]
        public IActionResult MostrarListado()
        {
            var lista = _noticiaService.ListarNoticias();
            return Ok(lista);
        }

        [HttpPost]
        [Route("Agregar")]
        public IActionResult Agregar([FromBody] Noticia _Noticia)
        {
            var resultado = _noticiaService.AgregarNoticia(_Noticia);
            if (resultado)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("Modificar")]
        public IActionResult Editar(Noticia _noticia)
        {
            var resultado = _noticiaService.EditarNoticia(_noticia);
            if (resultado)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("Eliminar/{noticiaID}")]
        public IActionResult Eliminar(int noticiaID)
        {
            var resultado = _noticiaService.EliminarNoticia(noticiaID);
            if (resultado)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}