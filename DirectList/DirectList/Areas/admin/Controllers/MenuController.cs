using DirectList.Data;
using DirectList.Models;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;
        public MenuController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.Menus.ToList());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu model)
        {
            _context.Menus.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)
        {
            Menu model = _context.Menus.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Menu model)
        {
            if (ModelState.IsValid)
            {
                _context.Menus.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id can not be null");
                return RedirectToAction("Index");
            }

            Menu menu = _context.Menus.Find(id);
            if (menu == null)
            {
                ModelState.AddModelError("", "Data can not be null");
                return RedirectToAction("Index");
            }
            _context.Menus.Remove(menu);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}