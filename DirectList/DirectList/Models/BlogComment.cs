using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80), Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(150), Required]

        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("ParentComment")]
        public int? ParentBlogCommentId { get; set; }
        public BlogComment ParentBlogComment { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

     

    }
}
