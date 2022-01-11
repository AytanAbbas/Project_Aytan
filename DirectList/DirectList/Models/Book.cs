using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string FullName { get; set; }
        public DateTime ReserveDate { get; set; }
        [MaxLength(10)]
        public byte PersonCount { get; set; }
        [MaxLength(30)]
        public string İD { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
