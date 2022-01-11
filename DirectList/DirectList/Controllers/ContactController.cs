using DirectList.Data;
using DirectList.Models;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new();
           model.Setting = _context.Settings.FirstOrDefault();
           model.Socials = _context.Socials.ToList();
           model.Banner= _context.Banners.FirstOrDefault(b => b.Page == "contact Us");
           return View(model);
        }
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(VmContact model)
        {
            if (ModelState.IsValid)
            {

                model.Contact.CreatedDate = DateTime.Now;
                _context.Contacts.Add(model.Contact);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", "Please check your information");


            return View("Index",model);
        }
    }
}
