using DirectList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.ViewModels
{
    public class VmBlog : VmLayout
    {
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public BlogComment BlogComment { get; set; }
        public Banner Banner { get; set; }
        public CustomUser CustomUser { get; set; }

    }
}