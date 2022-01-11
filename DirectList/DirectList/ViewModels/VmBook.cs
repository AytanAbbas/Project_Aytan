using DirectList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.ViewModels
{
    public class VmBook:VmLayout
    {
        public Restaurant Restaurant { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<FeatureToRestaurant> FeatureToRestaurants { get; set; }
        public Book Book { get; set; }
        public Banner Banner { get; set; }
        public RestaurantComment RestaurantComment { get; set; }
        public List<RestaurantComment> RestaurantComments { get; set; }

    }
}
