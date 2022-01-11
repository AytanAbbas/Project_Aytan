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
    public class FeatureController : Controller
    {
        private readonly AppDbContext _context;
        public FeatureController(AppDbContext context)
        {
            _context = context;
         
        }
        public IActionResult Index()
        {
            return View(_context.Features.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Feature model)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                return View(_context.Features.Find(id));

            }
            else
            {
                ModelState.AddModelError("", "Select Feature");
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Feature model)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            Feature model = null;

            if (id != null)
            {
                model = _context.Features.Find(id);
                _context.Features.Remove(model);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
