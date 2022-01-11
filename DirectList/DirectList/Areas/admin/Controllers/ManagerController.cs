using DirectList.Data;
using DirectList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class ManagerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ManagerController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.RestaurantManagers.Include(a => a.Restaurant).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Restaurants = _context.Restaurants.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantManager restaurantManager)
        {
            if (ModelState.IsValid)
            {

                if (restaurantManager.ImageFile != null)
                {
                    if (restaurantManager != null)
                    {
                        if (restaurantManager.ImageFile.ContentType == "image/png" || restaurantManager.ImageFile.ContentType == "image/jpeg")
                        {
                            if (restaurantManager.ImageFile.Length <= 2097152)
                            {
                                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + restaurantManager.ImageFile.FileName;
                                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    restaurantManager.ImageFile.CopyTo(stream);
                                }
                                restaurantManager.Image = fileName;

                                _context.RestaurantManagers.Add(restaurantManager);
                                _context.SaveChanges();
                                return RedirectToAction("Index");

                            }
                            else
                            {
                                ViewBag.Restaurants = _context.Restaurants.ToList();
                                ModelState.AddModelError("", "Your File can be then less 2MB");
                                return RedirectToAction("Index");
                            }
                        }
                        else
                        {
                            ViewBag.Restaurants = _context.Restaurants.ToList();
                            ModelState.AddModelError("", "Your File can be .png or .jpeg");
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    ViewBag.Restaurants = _context.Restaurants.ToList();
                    _context.RestaurantManagers.Add(restaurantManager);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }



                return RedirectToAction("Index");
            }
            ViewBag.Restaurants = _context.Restaurants.ToList();
            return View(restaurantManager);
        }
        public IActionResult Update(int? id)
        {
            RestaurantManager restaurantManager = _context.RestaurantManagers.Find(id);
            ViewBag.Restaurants = _context.Restaurants.ToList();

            return View(restaurantManager);
        }
        [HttpPost]
        public IActionResult Update(RestaurantManager restaurantManager)
        {
            if (ModelState.IsValid)
            {
                if (restaurantManager.ImageFile != null)
                {
                    if (restaurantManager.ImageFile.ContentType == "image/png" || restaurantManager.ImageFile.ContentType == "image/jpeg")
                    {
                        if (restaurantManager.ImageFile.Length <= 2097152)
                        {

                            string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", restaurantManager.Image);
                            if (!string.IsNullOrEmpty(restaurantManager.Image))
                            {
                                if (System.IO.File.Exists(oldPathFile))
                                {
                                    System.IO.File.Delete(oldPathFile);
                                }
                            }

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + restaurantManager.ImageFile.FileName;
                            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                restaurantManager.ImageFile.CopyTo(stream);
                            }

                            restaurantManager.Image = fileName;
                            _context.RestaurantManagers.Update(restaurantManager);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                    }
                }
                else
                {
                    ViewBag.Restaurants = _context.Restaurants.ToList();

                    _context.RestaurantManagers.Update(restaurantManager);
                    _context.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

            ViewBag.Restaurants = _context.Restaurants.ToList();

            return View(restaurantManager);
        }
        public IActionResult Delete(int? id)
        {
            RestaurantManager restaurantManager = null;


            if (id != null)
            {
                restaurantManager = _context.RestaurantManagers.Find(id);
            }


            if (!string.IsNullOrEmpty(restaurantManager.Image))
            {
                string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", restaurantManager.Image);

                if (System.IO.File.Exists(oldPathFile))
                {
                    System.IO.File.Delete(oldPathFile);
                }
            }


            if (restaurantManager != null)
            {
                _context.RestaurantManagers.Remove(restaurantManager);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "about not found");
                return View();
            }

        }
    }
 }
