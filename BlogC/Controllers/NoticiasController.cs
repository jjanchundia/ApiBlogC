using BlogC.Data;
using BlogC.Data.Interfaz;
using BlogC.Data.Models;
using BlogC.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace BlogC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoticiasController : ControllerBase
    {
        private readonly INoticiasRepository _context;
        private readonly NoticiasContext _noticiasContext;
        // GET: NoticiasController
        //public NoticiasController(NoticiasContext context)
        //Inyectamos Scoped de Startud
        public NoticiasController(INoticiasRepository context, NoticiasContext noticiasContext)
        {
            _context = context;
            _noticiasContext = noticiasContext;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            //var noticiaRepository = new NoticiasRepository(_context);
            return Ok(await _context.Listar());
        }

        [HttpGet]
        public async Task<IActionResult> GetPorId(Guid id)
        {
            //var noticiaRepository = new NoticiasRepository(_context);
            return Ok(await _context.ObtenerPorId(id));
        }

        [HttpPost]
        public IActionResult Crear(NoticiasModels model)
        {
            model.Id = Guid.NewGuid();
            //var noticiaRepository = new NoticiasRepository(_context);
            _context.Crear(model);
            return Ok(_noticiasContext.Noticias.OrderByDescending(x=>x.FechaCreacion).FirstOrDefault());
        }

        [HttpPut]
        public async Task<IActionResult> Editar(NoticiasModels model) 
        {
            _context.Editar(model);
            return Ok(); 
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(Guid id)
        {
            _context.Eliminar(id);
            return Ok();
        }

        [HttpDelete("DeletePorEstado/{id}")]
        public async Task<IActionResult> EliminarPorEstado(Guid id)
        {
            _context.EliminarPorEstado(id);
            return Ok();
        }

        [HttpPost("uploadFile")]
        public async Task<IActionResult> UploadFile([FromForm] Imagen file)
        {
            string imageFromFirebase = "";
            if (file.Imagen2.Length > 0)
            {
                string result = "";
                using (var ms = new MemoryStream())
                {
                    var s = file.Imagen2.CopyToAsync(ms);
                    result = Convert.ToBase64String(ms.ToArray());
                }

                file.FolderName = "Contenedores";
                var imageFromBase64ToStream = _context.ConvertBase64ToStream(result);
                var imageStream = imageFromBase64ToStream.ReadAsStream();

                imageFromFirebase = await _context.UploadImage(imageStream, file.ImageName);
            }

            return Ok(new string[]{
                imageFromFirebase
            });
        }        
    }
}