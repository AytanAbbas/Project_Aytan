using DirectList.Data;
using DirectList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class AboutProsessController : Controller
    {
      
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutProsessController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<AboutProcess> model = _context.AboutProcesses.ToList();
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(AboutProcess model)
        {
            if (ModelState.IsValid)
            {
                _context.AboutProcesses.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult Update(int id)
        {

            return View(_context.AboutProcesses.Find(id));
        }

        [HttpPost]
        public IActionResult Update(AboutProcess model)
        {
            if (ModelState.IsValid)
            {

                _context.AboutProcesses.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {

            AboutProcess process = _context.AboutProcesses.Find(id);

            _context.AboutProcesses.Remove(process);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
