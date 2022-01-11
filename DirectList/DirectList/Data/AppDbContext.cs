using DirectList.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutProcess> AboutProcesses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureToRestaurant> FeatureToRestaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuToRestaurant> MenuToRestaurants { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantComment> RestaurantComments { get; set; }
        public DbSet<RestaurantImage> RestaurantImages { get; set; }
        public DbSet<RestaurantManager> RestaurantManagers { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToRestaurant> TagToRestaurants { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
   
    }
}
