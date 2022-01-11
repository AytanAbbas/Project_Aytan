using DirectList.Data;
using DirectList.Models;
using DirectList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Controllers
{
    public class ListingController : Controller
    {
        private readonly AppDbContext _context;

        public ListingController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmSearch search)
        {

            List<Restaurant> restaurants = _context.Restaurants.Include(ri => ri.RestaurantImages)
                                                            .Include(tr => tr.TagToRestaurants).ThenInclude(t => t.Tag)
                                                           .Include(fr => fr.FeatureToRestaurants).ThenInclude(f => f.Feature)
                                                           .Include(mr => mr.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                           .Include(rc => rc.RestaurantComments)
                                                         .ToList();


            string oldData = Request.Cookies["cart"];

            List<string> cartList = null;

            if (!string.IsNullOrEmpty(oldData))
            {
                cartList = oldData.Split("-").ToList();
            }

            List<Restaurant> restaurants1 = new List<Restaurant>();

            if (cartList != null)
            {
                foreach (var item in cartList)
                {
                    Restaurant restaurant = _context.Restaurants.FirstOrDefault(i => i.Id.ToString() == item);

                    if (restaurant != null)
                    {
                        restaurants1.Add(restaurant);
                    }
                }
            }

            VmRestaurant vmRestaurant = new VmRestaurant()
            {
                Socials = _context.Socials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Restaurants = restaurants,
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "listings"),
            };
            vmRestaurant.Restaurants = _context.Restaurants.Include(bc => bc.RestaurantImages)

                                    .Where(b => (search.searchdata != null ? b.Name.Contains(search.searchdata) : true)).ToList();



            return View(vmRestaurant);
        }
        public IActionResult Detail(int? id)
        {
            Restaurant restaurant1 = null;
            if (id != null)
            {
                restaurant1 = _context.Restaurants.Find(id);
            }


            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            Restaurant restaurant = _context.Restaurants
                                                            .Include(rt => rt.TagToRestaurants).ThenInclude(t => t.Tag)
                                                            .Include(rf => rf.FeatureToRestaurants).ThenInclude(f => f.Feature)
                                                            .Include(rm => rm.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                            .Include(rr => rr.RestaurantComments).OrderByDescending(bc => bc.CreatedDate)
                                                            .Include(a => a.RestaurantManagers)
                                                            .FirstOrDefault(i => i.Id == id);

            VmBook detail = new VmBook()
            {
                Socials = socials,
                Setting = setting,
                Restaurant = restaurant,
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "listings"),
                RestaurantComment = _context.RestaurantComments.FirstOrDefault()
            };

            return View(detail);
        }
        [HttpPost]
        public IActionResult Comment(VmBook vmBookings)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Restaurant> restaurants = _context.Restaurants.ToList();

           

            if (ModelState.IsValid)
            {
                vmBookings.RestaurantComment.CreatedDate = DateTime.Now;
                _context.RestaurantComments.Add(vmBookings.RestaurantComment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            
                VmBook vmBooking = new VmBook()
                {
                    Socials = socials,
                    Setting = setting,
                    RestaurantComment = vmBookings.RestaurantComment,
                    Restaurant = vmBookings.Restaurant,
                    Restaurants = restaurants
                };
                return View("Index", vmBooking);
            

        }
        public IActionResult AddToCart(int? id)
        {
            string oldData = Request.Cookies["cart"];
            string newData = null;
            if (string.IsNullOrEmpty(oldData))
            {
                newData = id.ToString();
            }
            else
            {
                List<string> cartArr = oldData.Split("-").ToList();
                if (cartArr.Any(a => a == id.ToString()))
                {
                    cartArr.Remove(id.ToString());
                    newData = string.Join("-", cartArr);
                }
                else
                {
                    newData = oldData + "-" + id;
                }
            }

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };
            Response.Cookies.Append("cart", newData, options);

            return RedirectToAction("Index");

        }
        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(VmBook model)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> social = _context.Socials.ToList();

            VmBook vmBook = new VmBook()
            {
                Socials = social,
                Setting = setting
            };

            if (ModelState.IsValid)
            {
                if (DateTime.Now <= model.Book.CreatedDate)
                {

                    model.Book.RestaurantId = model.Restaurant.Id;
                    _context.Books.Add(model.Book);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

            return View("Index", model);
        }
    }


}

