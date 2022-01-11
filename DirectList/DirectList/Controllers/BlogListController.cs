using DirectList.Data;
using DirectList.Models;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Controllers
{
    public class BlogListController : Controller
    {
        private readonly AppDbContext _context;

        public BlogListController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Searchdata)
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blogs.ToList();
            model.CustomUser = _context.CustomUsers.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "blog Listing");
            model.Blogs = _context.Blogs.Where(b => (Searchdata != null ? b.Title.ToLower().Contains(Searchdata.ToLower()) : true)).ToList();
            return View(model);
        }
        public IActionResult BlogDetail(int? id)
        {
            Blog blog = null;
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Blog> blogs = _context.Blogs.ToList();
            CustomUser customUser = _context.CustomUsers.FirstOrDefault();
            Banner banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "blog detail");
            List<BlogComment> comments = _context.BlogComments.Where(i => i.BlogId == id).OrderByDescending(bc => bc.CreatedDate).ToList();
            if (id != null)
            {
                blog = _context.Blogs.Find(id);
            }

            VmBlog model = new VmBlog()
            {
                Blogs = blogs,
                Socials = socials,
                Setting = setting,
                Blog = blog,
                CustomUser = customUser,
                Banner = banner,
                BlogComments = comments
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Comment(VmBlog model)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Blog> blogs = _context.Blogs.ToList();

            if (ModelState.IsValid)
            {
                model.BlogComment.CreatedDate = DateTime.Now;
                _context.BlogComments.Add(model.BlogComment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            VmBlog vmBlog = new VmBlog()
            {
                Socials = socials,
                Setting = setting,
                BlogComment = model.BlogComment,
                Blog = model.Blog,
                Blogs = blogs
            };



            return View("Index", vmBlog);
        }
    }
}

  
   