using DirectList.Data;
using DirectList.Models;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
    public class MenuToRestaurantController : Controller
    {
        private readonly AppDbContext _context;
        public MenuToRestaurantController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<MenuToRestaurant> model = _context.MenuToRestaurants.Include(m => m.Menu).Include(r => r.Restaurant).ToList();
            return View(model);

        }
        public IActionResult Create()
        {
            ViewBag.Menu = _context.Menus.ToList();
            ViewBag.Restaurant = _context.Restaurants.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(MenuToRestaurant menuToRestaurant)
        {
            if (ModelState.IsValid)
            {
                _context.MenuToRestaurants.Add(menuToRestaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuToRestaurant);
        }
        public IActionResult Update(int? Id)
        {
            MenuToRestaurant model = _context.MenuToRestaurants.FirstOrDefault(i => i.Id == Id);
            ViewBag.Menu = _context.Menus.ToList();
            ViewBag.Restaurant = _context.Restaurants.ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult Update(MenuToRestaurant menuToRestaurant)
        {
           
            if (ModelState.IsValid)
            {
                _context.MenuToRestaurants.Update(menuToRestaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(menuToRestaurant);
        }
        public IActionResult Delete(int? Id)
        {
            MenuToRestaurant model = null;

            if (Id != null)
            {
                model = _context.MenuToRestaurants.Find(Id);
            }

            if (model != null)
            {
                _context.MenuToRestaurants.Remove(model);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
