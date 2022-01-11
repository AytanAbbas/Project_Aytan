using DirectList.Data;
using DirectList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class TagController : Controller
    {
        private readonly AppDbContext _context;
        public TagController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.Tags.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tag model)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                return View(_context.Tags.Find(id));

            }
            else
            {
                ModelState.AddModelError("", "Select Tag");
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Tag model)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            Tag model = null;

            if (id != null)
            {
                model = _context.Tags.Find(id);
                _context.Tags.Remove(model);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
