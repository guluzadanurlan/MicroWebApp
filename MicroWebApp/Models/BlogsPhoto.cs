using System;
using System.Collections.Generic;

#nullable disable

namespace MicroWebApp.Models
{
    public partial class BlogsPhoto
    {
        public int Id { get; set; }
        public int? BlogId { get; set; }
        public string PhotoPath { get; set; }
        public bool? Statsu { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
