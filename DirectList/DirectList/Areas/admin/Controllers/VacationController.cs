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
    public class VacationController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VacationController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Vacation> model = _context.Vacations.ToList();
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Vacation model)
        {
            if (ModelState.IsValid)
            {
                _context.Vacations.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult Update(int id)
        {

            return View(_context.Vacations.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Vacation model)
        {
            if (ModelState.IsValid)
            {

                _context.Vacations.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {

            Vacation vacation = _context.Vacations.Find(id);

            _context.Vacations.Remove(vacation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
