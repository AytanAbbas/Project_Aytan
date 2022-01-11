using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        public List<MenuToRestaurant> MenuToRestaurants { get; set; }
    }
}
