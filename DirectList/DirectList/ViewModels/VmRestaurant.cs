using DirectList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.ViewModels
{
    public class VmRestaurant : VmLayout
    {
        public List<Restaurant> Restaurants { get; set; }
        public Restaurant Restaurant { get; set; }
        public Banner Banner { get; set; }
        public Book Book { get; set; }
        public List<string> AddToCart { get; set; }
        public VmSearch Search { get; set; }
        public List<RestaurantImage> RestaurantImages { get; set; }
        public RestaurantComment RestaurantComment { get; set; }
        public List<RestaurantComment> RestaurantComments { get; set; }

       
    }
}