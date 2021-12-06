using BlogC.Data;
using BlogC.Data.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlogC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly NoticiasContext _context;
        private readonly IUsuarioRepository _context2;
        public UsuarioController(NoticiasContext context, IUsuarioRepository context2)
        {
            _context = context;
            _context2 = context2;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context2.Listar());
        }

        [HttpGet("GetPorId")]
        public async Task<IActionResult> GetPorId(Guid id)
        {
            return Ok(await _context2.ObtenerPorId(id));
        }

        [HttpGet("IniciarSesion={correo}/{password}")]
        public IActionResult IniciarSesion(string correo, string password)
        {
            var usuario = _context.Usuario.Where(x => x.Correo == correo && x.Password == password);
            return Ok(usuario.FirstOrDefault());
        }

        //[HttpPost("Crear")]
        //public IActionResult Crear(UsuarioModels model)
        //{
        //    model.IdUsuario = Guid.NewGuid();
        //    //var noticiaRepository = new NoticiasRepository(_context);
        //    _context2.Crear(model);
        //    return Ok();
        //}

        //[HttpPut("Editar")]
        //public async Task<IActionResult> Editar(UsuarioModels model)
        //{
        //    _context2.Editar(model);
        //    return Ok();
        //}

        [HttpDelete("Eliminar")]
        public async Task<IActionResult> Eliminar(Guid id)
        {
            _context2.Eliminar(id);
            return Ok();
        }

        [HttpDelete("DeletePorEstado/{id}")]
        public async Task<IActionResult> EliminarPorEstado(Guid id)
        {
            _context2.EliminarPorEstado(id);
            return Ok();
        }
    }
}