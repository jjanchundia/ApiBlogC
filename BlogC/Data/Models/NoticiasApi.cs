using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogC.Data.Models
{
    public class NoticiasApi
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public DateTime publishedAt { get; set; }
    }
}
