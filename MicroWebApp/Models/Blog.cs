using System;
using System.Collections.Generic;

#nullable disable

namespace MicroWebApp.Models
{
    public partial class Blog
    {
        public Blog()
        {
            BlogsPhotos = new HashSet<BlogsPhoto>();
            Coments = new HashSet<Coment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CategoryId { get; set; }
        public bool? Status { get; set; }
        public string AuthorId { get; set; }

        public virtual AspNetUser Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<BlogsPhoto> BlogsPhotos { get; set; }
        public virtual ICollection<Coment> Coments { get; set; }
    }
}
