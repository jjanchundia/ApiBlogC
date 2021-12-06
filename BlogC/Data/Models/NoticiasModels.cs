using System;

namespace BlogC.Data.Models
{
    public class NoticiasModels
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Imagen { get; set; }        
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        //public IFormFile Foto { get; set; }
            
    }
}
