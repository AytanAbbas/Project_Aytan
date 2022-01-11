using DirectList.Data;
using DirectList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {

            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/png" || blog.ImageFile.ContentType == "image/jpeg")
                    {
                        if (blog.ImageFile.Length <= 2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + blog.ImageFile.FileName;
                            string pathName = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                            using (var stream = new FileStream(pathName, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(stream);

                            }
                            blog.Image = fileName;
                            blog.CreatedDate = DateTime.Now;

                            _context.Blogs.Add(blog);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2mb");
                            return View(blog);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg , .jpg and .png");
                        return View(blog);
                    }
                }
                else
                {
                    return View(blog);

                }
            }

            return View(blog);
        }

        public IActionResult Update(int? id)
        {
            Blog blog = _context.Blogs.Find(id);


            return View(blog);
        }

        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/png" || blog.ImageFile.ContentType == "image/jpeg")
                    {
                        if (blog.ImageFile.Length <= 2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + blog.ImageFile.FileName;
                            string pathName = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                            using (var stream = new FileStream(pathName, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(stream);

                            }
                            blog.Image = fileName;
                            blog.CreatedDate = DateTime.Now;
                            blog.CustomUserId = "djfv";

                            _context.Blogs.Update(blog);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2mb");
                            return View(blog);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg , .jpg and .png");
                        return View(blog);
                    }
                }
                else
                {
                    return View(blog);

                }
            }

            return View(blog);
        }

        public IActionResult Delete(int? id)
        {

            Blog blog = _context.Blogs.Find(id);

            if (id != null)
            {
                string pathFIle = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", blog.Image);
                if (!string.IsNullOrEmpty(blog.Image))
                {
                    if (System.IO.File.Exists(pathFIle))
                    {
                        System.IO.File.Delete(pathFIle);
                    }
                }
            }

            if (blog != null)
            {
                _context.Blogs.Remove(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }
    }
}
