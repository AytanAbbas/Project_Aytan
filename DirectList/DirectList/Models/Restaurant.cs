using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(2000)]
        public string About { get; set; }
        [MaxLength(30)]
        public string ReceptionPhone { get; set; }
        [MaxLength(30)]
        public string CompaintPhone { get; set; }
        [MaxLength(30)]
        public string SupportPhone { get; set; }
        [MaxLength(250)]
        public string Location { get; set; }
        [MaxLength(500)]
        public string LocationNote { get; set; }
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public List<IFormFile> RestaurantImageFile { get; set; }
        [NotMapped]
        public List<int> Tags { get; set; }

        [NotMapped]
        public List<int> Features { get; set; }
        [NotMapped]
        public List<int> TagToRestaurantId { get; set; }
        [NotMapped]
        public List<int> MenuToRestaurantId { get; set; }

        [NotMapped]
        public List<int> FeatureToRestaurantId { get; set; }

        public List<MenuToRestaurant> MenuToRestaurants { get; set; }
        public List<RestaurantManager> RestaurantManagers { get; set; }
        public List<TagToRestaurant> TagToRestaurants { get; set; }
        public List<FeatureToRestaurant> FeatureToRestaurants { get; set; }
        public List<RestaurantImage> RestaurantImages { get; set; }
        public List<Book> Books { get; set; }
        public List<RestaurantComment> RestaurantComments { get; set; }
       
    }
}
