using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class Vacation
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(15)]
        public string Number { get; set; }
    }
}
