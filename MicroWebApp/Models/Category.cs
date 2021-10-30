using System;
using System.Collections.Generic;

#nullable disable

namespace MicroWebApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }

        public int Id { get; set; }
        public string Categories { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
