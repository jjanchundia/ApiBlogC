using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogC.Data.Models
{
    public class Imagen
    {
        public IFormFile Imagen2 { get; set; }
        public string FolderName { get; set; }
        public string ImageName { get; set; }
        //public string? Url { get; set; }
    }
}
