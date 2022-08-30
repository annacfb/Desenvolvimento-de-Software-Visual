using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> usuarios  = new List<Usuario>();

        //GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(usuarios);
        }

        // POST: /api/usuario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar(
            [FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            return Created("", usuario);
        }

        //GET: /api/usuario/buscar/{login}
        [HttpGet]
        [Route("buscar/{Nome}")]
        public IActionResult Buscar([FromRoute] string Nome)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if(usuarios[i].Nome.Equals(Nome))
                {
                    return Ok(usuarios[i]);
                }
            }
            return NotFound();
        }

        [HttpPost]
        [Route("deletar")]
        public IActionResult Deletar(
            [FromBody] Usuario usuario)
        {
            usuarios.DeleteAsync(usuario);
            Return (Deletar);
        }
    }
}