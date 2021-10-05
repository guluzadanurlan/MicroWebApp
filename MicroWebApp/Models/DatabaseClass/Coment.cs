using System;
using System.Collections.Generic;

#nullable disable

namespace MicroWebApp.Models
{
    public partial class Coment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ComentText { get; set; }
        public int? BlogId { get; set; }
        public bool? Status { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
