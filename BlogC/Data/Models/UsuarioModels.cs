using System;

namespace BlogC.Data.Models
{
    public class UsuarioModels
    {
        public Guid IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}