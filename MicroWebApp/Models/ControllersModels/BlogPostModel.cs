using System;
using System.ComponentModel.DataAnnotations;

namespace MicroWebApp.Models
{
    public class BlogPostModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime? CreateDate { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public bool? Status { get; set; }
        [Required]
        public string AuthorId { get; set; }
       
    }
}