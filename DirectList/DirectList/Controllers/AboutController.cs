using DirectList.Data;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "about Us");
            model.Setting = _context.Settings.FirstOrDefault();
            model.About = _context.Abouts.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.AboutProcesses = _context.AboutProcesses.ToList();

            return View(model);
        }
    }
}
